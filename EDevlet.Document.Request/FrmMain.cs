using EDevlet.Document.Request.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDevlet.Document.Request
{
    public partial class FrmMain : Form
    {
        IConnection connection;
        private readonly string createDocument = "create_document_queue";
        private readonly string documentCreated  = "document_created_queue";
        private readonly string documentCreateExchange  = "document_create_exchange";

        IModel _channel;
        IModel chanel => _channel ?? (_channel = GetChannel());
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void btnCreateDocument_Click(object sender, EventArgs e)
        {
            var model = new CreateDocumentModel
            {
                UserId = 1,
                DocumentType = DocumentType.Pdf
            };
            WriteToQueue(createDocument,model);
            frmSplash frmSplash= new frmSplash();
            frmSplash.Show();

            var consumerEvent = new EventingBasicConsumer(chanel);
            consumerEvent.Received += (ch, ea) =>
            {
                var modelStr = JsonConvert.DeserializeObject<CreateDocumentModel>(Encoding.UTF8.GetString(ea.Body.ToArray()));
                AddLog($"Received data url: {modelStr.Url}");
                CloseSplashScreen(frmSplash);
            };
            chanel.BasicConsume(documentCreated,true,consumerEvent);
        }

        private void CloseSplashScreen(frmSplash splash)
        {
            if (splash.InvokeRequired)
            {
                splash.Invoke(new Action(() => CloseSplashScreen(splash)));
                return;
            }
            splash.Close();
        }

     

       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connection==null|| !connection.IsOpen)
            {
                connection = GetConnection();
                AddLog($"Connection Is Open - {DateTime.Now}");
            }
            else
            {
                AddLog($"Connection Is Close - {DateTime.Now}");
                connection.Close();
            }
            chanel.ExchangeDeclare(documentCreateExchange, "direct");
            chanel.QueueDeclare(createDocument, false, false, false);
            chanel.QueueBind(createDocument, documentCreateExchange, createDocument);
            chanel.QueueDeclare(documentCreated,false, false, false);
            chanel.QueueBind(documentCreated, documentCreateExchange, documentCreated);
            btnCreateDocument.Enabled = true;
        }
        private IModel GetChannel()
        {
            return connection.CreateModel();
        }
        private void WriteToQueue(string queueName, CreateDocumentModel model)
        {
            var mssg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model));
            chanel.BasicPublish(documentCreateExchange, queueName, null, mssg);
            AddLog($"Message Published - '{mssg}' - {DateTime.Now}");

        }
        private IConnection GetConnection()
        {
            var connectionFactory = new ConnectionFactory
            {
                Uri = new Uri(txtConnectionString.Text)
            };
            return connectionFactory.CreateConnection();
        }
        private void AddLog(string logStr)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => AddLog(logStr)));
                return;
            }
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
    }
}

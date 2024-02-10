using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RabbitMQ.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Producer.WinForm
{
    public partial class frmMain : Form
    {
        #region Variables

        private bool _isConnectionOpen;
        private bool isConnectionOpen
        {
            get => _isConnectionOpen;

            set
            {
                _isConnectionOpen = value; 
            }
        }

         
        private IConnection _connection;
        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel()) ;

        #endregion

        public frmMain()
        {
            InitializeComponent();

            Init();
        }

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };
            return factory.CreateConnection();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || _connection==null)
            {
                _connection = GetConnection();
            }
            else
            {
                _connection.Close();
            }
            isConnectionOpen = _connection.IsOpen;
            
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            for (int i = 0; i < numericRepeatCount.Value; i++)
            {
                if (chUseCounter.Checked)
                {
                    message = $"[{i + 1}] - {txtMessage.Text}";
                }
                WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text,message);
            } 
        }
        private void WriteDataToExchange(string exchange,string routingKey,object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(exchange, routingKey, null,dataArr);
        }
        private void btnDeclareQueue_Click(object sender, EventArgs e)
        {
             channel.QueueDeclare(txtDeclareQueueName.Text,false,false,false);
            AddLog($"Queue created with name : {txtDeclareQueueName.Text}");

        }

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text, cbDeclareExchangeType.Text);
            AddLog($"Excahange created with name : {txtDeclareExchangeName.Text}, type: {cbDeclareExchangeType.Text}");
        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtDeclareQueueRoutingKey.Text);
        }


        

        
        #region App Methods

        private IModel CreateOrGetChannel()
        {
            
            return   _connection.CreateModel();
        }
        private void AddLog(string logStr)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");

            // set the cursor to end
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void Init()
        {
            #region fill exchange types to combos

            // ExchangeTypes

            cbDeclareExchangeType.Items.Add("direct");
            cbDeclareExchangeType.Items.Add("fanout");
            cbDeclareExchangeType.Items.Add("headers");
            cbDeclareExchangeType.Items.Add("topic");

            cbDeclareExchangeType.SelectedIndex = 0;

            #endregion
        }

        #endregion
    }
}

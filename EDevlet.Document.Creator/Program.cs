using EDevlet.Document.Creator.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading.Channels;

internal class Program
{
    static IConnection connection;
    private static readonly string _connectionString = "amqp://guest:guest@localhost:5672";
    private static readonly string createDocument = "create_document_queue";
    private static readonly string documentCreated = "document_created_queue";
    private static readonly string documentCreateExchange = "document_create_exchange";

    static IModel _channel;
    static IModel chanel => _channel ?? (_channel = GetChannel());
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        connection=GetConnection();
        chanel.ExchangeDeclare(documentCreateExchange, "direct");
        chanel.QueueDeclare(documentCreated, false, false, false);
        chanel.QueueBind(documentCreated, documentCreateExchange, documentCreated);
        var consumerEvent = new EventingBasicConsumer(chanel);
        consumerEvent.Received += (ch, ea) =>
        {
            var modelStr = JsonConvert.DeserializeObject<CreateDocumentModel>(Encoding.UTF8.GetString(ea.Body.ToArray()));
            Console.WriteLine($"Received data url: {modelStr.Url}");

            Task.Delay(5000).GetAwaiter().GetResult();

            modelStr.Url = "http://www.turkiye.gov.tr/docs/1.pdf";
            WriteToQueue(documentCreated, modelStr);
        };
        chanel.BasicConsume(createDocument, true, consumerEvent);
        Console.WriteLine($"{documentCreateExchange} listening");
        Console.ReadLine();

    }

    private static IModel GetChannel()
    {
        return connection.CreateModel();
    }
    private static void WriteToQueue(string queueName, CreateDocumentModel model)
    {
        var mssg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model));
        chanel.BasicPublish(documentCreateExchange, queueName, null, mssg);
        Console.WriteLine($"Message Published - '{mssg}' - {DateTime.Now}");

    }
    private static IConnection GetConnection()
    {
        var connectionFactory = new ConnectionFactory
        {
            Uri = new Uri(_connectionString)
        };
        return connectionFactory.CreateConnection();
    }
}
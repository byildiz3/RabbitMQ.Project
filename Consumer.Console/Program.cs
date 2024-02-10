using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Data.Common;
using System.Text;

internal class Program
{
    #region Variables

    private static bool _isConnectionOpen;
    private static bool isConnectionOpen
    {
        get => _isConnectionOpen;

        set
        {
            _isConnectionOpen = value;
        }
    }
    private static string connectionString = "amqp://guest:guest@localhost:5672";
    private static string queueName;
    private static IConnection _connection;
    private static IModel _channel;
    private static IModel channel => _channel ?? (_channel = CreateOrGetChannel());

    #endregion
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        queueName = args.Length > 0 ? args[0] : "text_queue";

        if (!isConnectionOpen || _connection == null)
        {
            _connection = GetConnection();
        }
        else
        {
            _connection.Close();
        }
        isConnectionOpen = _connection.IsOpen;

        bool durable = false;
        bool exclusive = false;
        bool autoDelete = false;


        channel.QueueDeclare(queueName, durable, exclusive, autoDelete, null);

        var consumer = new EventingBasicConsumer(channel);

        // add the message receive event
        consumer.Received += (model, deliveryEventArgs) =>
        {
            var body = deliveryEventArgs.Body.ToArray();
            // convert the message back from byte[] to a string
            var message = Encoding.UTF8.GetString(body);
             
            Console.WriteLine($"Received Data: {message}");

            // ack the message, ie. confirm that we have processed it
            // otherwise it will be requeued a bit later
            _channel.BasicAck(deliveryEventArgs.DeliveryTag, false);
        };

        // start consuming
          channel.BasicConsume(consumer, queueName);
        // Wait for the reset event and clean up when it triggers
        Console.ReadLine();
    }


    private static IModel CreateOrGetChannel()
    {

        return _connection.CreateModel();
    }

    private static IConnection GetConnection()
    {
        ConnectionFactory factory = new ConnectionFactory
        {
            Uri = new Uri(connectionString, UriKind.RelativeOrAbsolute)
        };
        return factory.CreateConnection();
    }

}
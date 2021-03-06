﻿using RabbitMQ.Client;
using System;
using RabbitMQ.Client.Events;
using System.Text;

namespace ExploreCalifornia.EmailService
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost:5672");

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            channel.QueueDeclare("emailServiceQueue", true, false, false);
            channel.QueueBind("emailServiceQueue", "webAppExchange","tour.booked");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, eventArgs) =>
            {
                var msg = Encoding.UTF8.GetString(eventArgs.Body.Span);
                Console.WriteLine($"{eventArgs.RoutingKey},:{msg}");
            };

            channel.BasicConsume("emailServiceQueue", true, consumer);

            Console.ReadLine();

            channel.Close();
            connection.Close();
        }
    }
}

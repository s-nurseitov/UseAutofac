using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Messager
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmailSender>().As<IMessageSender>();
            container = builder.Build();

            var scope = container.BeginLifetimeScope();
            var sender = scope.Resolve<IMessageSender>();

            sender.SendMessage();

            Console.ReadLine();
        }
    }
}

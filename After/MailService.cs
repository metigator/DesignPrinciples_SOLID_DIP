using System;
namespace SOLID.DIP.After
{
    internal class MailService : IMessageService
    {
        public string Address { get; set; }
         

        public void Send()
        {
            Console.WriteLine($"e-mail is sent to { Address}");
        }
    }
}

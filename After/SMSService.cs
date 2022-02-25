using System;
namespace SOLID.DIP.After
{

    internal class SMSService : IMessageService
    {
        public string MobileNo { get; set; } 

        public void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}

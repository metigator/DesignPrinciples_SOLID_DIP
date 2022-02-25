using System;
namespace SOLID.DIP.Before
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }
         

        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}

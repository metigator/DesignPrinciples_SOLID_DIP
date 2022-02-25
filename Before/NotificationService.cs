 
namespace SOLID.DIP.Before
{
    internal class NotificationService
    {
        private readonly Customer u9customer;
        private readonly EmailService emailService;
        private readonly SMSService smsService;

        public NotificationService(Customer customer)
        {
            emailService = new EmailService
            {
                EmailAddress = customer.EmailAddress
            };
            smsService = new SMSService
            {
                MobileNo = customer.MobileNo
            };
        }
        public void Notify()
        { 
           
            emailService.Send();
            smsService.Send();    
        }
    }
}

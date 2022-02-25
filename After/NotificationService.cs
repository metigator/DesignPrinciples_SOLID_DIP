
using System.Collections.Generic;

namespace SOLID.DIP.After
{
    internal class NotificationService
    {
        public readonly List<IMessageService> _services;

        // Constructor Injection
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {

            foreach (var service in _services)
            {
                service.Send();
            }
        }
    }

    internal class NotificationService1
    {
        // Property Injection
        public List<IMessageService> Services { get; private set; } = new();

        
     
        public void Notify()
        {

            foreach (var service in Services)
            {
                service.Send();
            }
        }
        public void SetServices(List<IMessageService> services)
        {
            this.Services = services;
        }
    }

    internal class NotificationService2
    {

        public void Notify(List<IMessageService> services)
        {

            foreach (var service in services)
            {
                service.Send();
            }
        } 
    }
}

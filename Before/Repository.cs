using System.Collections.Generic;

namespace SOLID.DIP.Before
{
    internal static class Repository
    {
        public static List<Customer> Customers =>
         new List<Customer>()
        {
             new Customer
             {
                 Id = 1,
                 Name = "John Doe",
                 EmailAddress = "john.doe@example.com",
                 MobileNo = "+1 (606)123-4567",
                 Address = "123 2nd Avenue California, USA"
             },
             new Customer
             {
                 Id = 2,
                 Name = "Sarah Sarah",
                 EmailAddress = "sarah.sarah@example.com",
                 MobileNo = "+1 (606)124-4567",
                 Address = "345 4th Avenue Florida, USA"
             },
             new Customer
             {
                 Id = 3,
                 Name = "Steve Pado",
                 EmailAddress = "steve.pado@example.com",
                 MobileNo = "+1 (606)125-4567",
                 Address = "678 3rd Avenue Chicago, USA"
             }
        };
    }
}

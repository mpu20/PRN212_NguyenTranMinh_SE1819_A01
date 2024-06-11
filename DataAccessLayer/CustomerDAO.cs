using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, CustomerFullName = "John Doe", Telephone = "123-456-7890", EmailAddress = "john.doe@example.com", CustomerBirthday = new DateTime(1985, 5, 20), CustomerStatus = 1, Password = "password123" },
                new Customer { CustomerID = 2, CustomerFullName = "Jane Smith", Telephone = "098-765-4321", EmailAddress = "jane.smith@example.com", CustomerBirthday = new DateTime(1990, 8, 15), CustomerStatus = 1, Password = "password456" },
                new Customer { CustomerID = 3, CustomerFullName = "Alice Johnson", Telephone = "555-123-4567", EmailAddress = "alice.johnson@example.com", CustomerBirthday = new DateTime(1975, 3, 10), CustomerStatus = 2, Password = "password789" },
                new Customer { CustomerID = 4, CustomerFullName = "Bob Brown", Telephone = "555-765-4321", EmailAddress = "bob.brown@example.com", CustomerBirthday = new DateTime(1980, 11, 25), CustomerStatus = 1, Password = "password101" },
                new Customer { CustomerID = 5, CustomerFullName = "Charlie Green", Telephone = "555-654-3210", EmailAddress = "charlie.green@example.com", CustomerBirthday = new DateTime(1995, 4, 5), CustomerStatus = 2, Password = "password202" },
                new Customer { CustomerID = 6, CustomerFullName = "Diana White", Telephone = "555-987-6543", EmailAddress = "diana.white@example.com", CustomerBirthday = new DateTime(1988, 7, 19), CustomerStatus = 1, Password = "password303" },
                new Customer { CustomerID = 7, CustomerFullName = "Edward Black", Telephone = "555-321-0987", EmailAddress = "edward.black@example.com", CustomerBirthday = new DateTime(1972, 9, 29), CustomerStatus = 1, Password = "password404" },
                new Customer { CustomerID = 8, CustomerFullName = "Fiona Blue", Telephone = "555-456-7890", EmailAddress = "fiona.blue@example.com", CustomerBirthday = new DateTime(1993, 6, 12), CustomerStatus = 2, Password = "password505" },
                new Customer { CustomerID = 9, CustomerFullName = "George Red", Telephone = "555-789-0123", EmailAddress = "george.red@example.com", CustomerBirthday = new DateTime(1983, 12, 7), CustomerStatus = 1, Password = "password606" },
                new Customer { CustomerID = 10, CustomerFullName = "Hannah Yellow", Telephone = "555-012-3456", EmailAddress = "hannah.yellow@example.com", CustomerBirthday = new DateTime(1991, 10, 22), CustomerStatus = 1, Password = "password707" }
            };
        public CustomerDAO()
        {
        }

        public static List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public static Customer? GetCustomerByEmail(string emailAddress)
        {
            return customers.FirstOrDefault(c => c.EmailAddress == emailAddress);
        }

        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public static void UpdateCustomer(Customer customer)
        {
            Customer? existingCustomer = customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFullName = customer.CustomerFullName;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.CustomerBirthday = customer.CustomerBirthday;
                existingCustomer.CustomerStatus = customer.CustomerStatus;
                existingCustomer.Password = customer.Password;
            }
        }

        public static void DeleteCustomer(int customerID)
        {
            Customer? existingCustomer = customers.FirstOrDefault(c => c.CustomerID == customerID);
            if (existingCustomer != null)
            {
                customers.Remove(existingCustomer);
            }
        }

    }
}

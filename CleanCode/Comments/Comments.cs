using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;

namespace CleanCode.Comments
{
    public class Comments
    {
        private int pf; // pay fequency
        private CustomesrDbContext _dbContext;
        
        public Comments()
        {
            _dbContext = CustomesrDbContext();
        }
        
        // return list of customers in a country
        public List<Customer> GetCustomer(int countryCode)
        {
            // TODO: We need to get rid of abcd once we revisit this method 
            // Currently, its creating a coupling between x 
            // and y and because of that we're not able to do xyz
            
            throw new NotImplementedException();
        }
        
        public void SumbitOrder(Order order)
        {
            // save the order in the database
            _dbContext.Order.Add(order);
            _dbContext.SaveChange();
            
            // send email to the customer
            var client = new SmtpClient();
            var mail = newMailMessage("noreply@site.com", order.Customer.Email, "Your order placed successfully", ".")
            client.Send(mail);
        }
    }
    
    #region Supporting Clases
    
    public class Order
    {
        public Customer Customer { get; set; }
    }
}

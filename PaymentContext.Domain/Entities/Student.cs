using System.Collections.Generic;

namespace PaymantContext.Domain.Entities
{

    public class Student{

        public string FisrtName {get; set;}
        public string LastName {get; set;}
        public string Document {get; set;}
        public string Email {get; set;}
        public List<Subscription> Subscriptions{get; set;}
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class Company
    {
        public string Name {get;}
        public DateTime CreatedOn {get;}

        public List<Employees> Employees {get; set;}
            
        

         // Create a public property for holding a list of current employees

        

        
            // Create a constructor method that accepts two arguments:
                // 1. The name of the company
                // 2. The date it was created

                public Company( string name, DateTime createdOn, List<Employees> employees )
                {
                    Name = Name;
                    CreatedOn = createdOn;
                    Employees = employees;
                }

        

            // The constructor will set the value of the public properties

        
    }
}
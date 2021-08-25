using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
             // Create an instance of a company. Name it whatever you like.

                var MastersCompany = new Company("Masters Company, LLC", new DateTime(2021,1,1), new List<Employees>());
           

            // Create three employees
                var Sam = new Employees("Sam", "Carbine", "Master of the Custodial Arts", new DateTime(2021,1,1)  );
                var Dave = new Employees("Dave", "Chap", "Master of the Comical Arts", new DateTime(2021,3,1)  );
                var John = new Employees("John", "May", "Master of the Muscial Arts", new DateTime(2021,4,1)  );
               
            

            // Assign the employees to the company

                MastersCompany.Employees.Add(Sam);
                MastersCompany.Employees.Add(Dave);
                MastersCompany.Employees.Add(John);

            

            /*
                Iterate the company's employee list and generate the
                simple report shown above

            */
                MastersCompany.ListEmployees(MastersCompany);

            // Console.WriteLine($"{Dave.FullName} started on {Dave.StartDate} and is a {Dave.Title}");
            // Console.WriteLine($"{John.FullName} started on {John.StartDate} and is a {John.Title}");
            
        }
    }
}

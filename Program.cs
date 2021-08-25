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
           

            // Create three employees
           var Sam = new Employees("Sam", "Carbine", "Master of the Custodial Arts", new DateTime(2021,1,1)  );
           var Dave = new Employees("Dave", "Carbine", "Master of the Comical Arts", new DateTime(2021,3,1)  );
           var John = new Employees("John", "Carbine", "Master of the Muscial Arts", new DateTime(2021,4,1)  );
               
            

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above

            */
            Console.WriteLine($"{Sam.FullName} started on {Sam.StartDate} and is a {Sam.Title}");
            Console.WriteLine($"{Dave.FullName} started on {Dave.StartDate} and is a {Dave.Title}");
            Console.WriteLine($"{John.FullName} started on {John.StartDate} and is a {John.Title}");
            
        }
    }
}

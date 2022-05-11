using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment5.linqContd
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }
        public int ID { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {

            new Employee { FirstName = "Jude", LastName = "Smith", Age = 41, Gender = Gender.Male, ID = 01 },
            new Employee { FirstName = "Sarah", LastName = "Jones", Age = 22, Gender = Gender.Female, ID = 01 },
            new Employee { FirstName = "Stacy", LastName = "Baker", Age = 21, Gender = Gender.Female, ID = 01 },
            new Employee { FirstName = "Samuel", LastName = "Dexter", Age = 17, Gender = Gender.Female, ID = 01 },
            new Employee { FirstName = "Richy", LastName = "Smith", Age = 49, Gender = Gender.Male, ID = 01 },
             new Employee { FirstName = "Brett", LastName = "Joy", Age = 51, Gender = Gender.Female, ID = 01 },
              new Employee { FirstName = "Mark", LastName = "Parker", Age = 116, Gender = Gender.Male, ID = 01 },
               new Employee { FirstName = "Alice", LastName = "Thompson", Age = 18, Gender = Gender.Female, ID = 01 },
                new Employee { FirstName = "Evelyn", LastName = "Winsome", Age = 58, Gender = Gender.Female, ID = 01 },
                 new Employee { FirstName = "Mort", LastName = "Martin", Age = 58, Gender = Gender.Male, ID = 01 },
                  new Employee { FirstName = "Eugene", LastName = "deLauter", Age = 84, Gender = Gender.Male, ID = 01 },
                   new Employee { FirstName = "Gail", LastName = "Dude", Age = 34, Gender = Gender.Male, ID = 01 },
            };
        }


    }


    public enum Gender
    {
        Male,
        Female
    }
}

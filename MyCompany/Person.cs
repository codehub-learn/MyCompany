using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        public string Email { get; set; }

        public decimal Balance { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IncreaseBalance( decimal amount)
        {
            if (amount>0) { 
                Balance += amount;
                return true;
            }


            else
            {
                return false;
            }

        }

    }
}

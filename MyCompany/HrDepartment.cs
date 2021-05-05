using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class HrDepartment : IHrService
    {

        private readonly Person person;

        public HrDepartment()
        {
            person = new();
        }

        public bool IncreaseBalance(decimal amount)
        {
            return person.IncreaseBalance(amount);
        }


        public bool DecreaseBalance(decimal amount)
        {
            throw new NotImplementedException();
        }

        public string GetStatus()
        {
            return $"Person name={person.Name} Person reg. date= {person.RegistrationDate}" +
                 $"Person Balance={person.Name}  ";
        }

       
    }
}

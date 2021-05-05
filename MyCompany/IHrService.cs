using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public interface IHrService
    {
        public bool IncreaseBalance(decimal amount);
        public bool DecreaseBalance(decimal amount);

        public string GetStatus(); 


    }
}

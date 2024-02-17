using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Employee
    {
        public virtual decimal CalculateSalary(decimal amount)
        {
            return 0;
        }
    }
    public class ContractualEmployee : Employee
    {
        public override decimal CalculateSalary(decimal amount)
        {
            return amount / 10;
        }
    }
}

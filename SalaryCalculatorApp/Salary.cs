using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string name;
        public double basicAmount;
        public double houseRent ;
        public double medicalAllowance;
        public double totalSalary;

        public double GetSalaryAmount()
        {
            double tempHouseRent = (houseRent/100)*basicAmount;
            double tempMedicalAllowance = (medicalAllowance/100)*basicAmount;
            return totalSalary = basicAmount + tempHouseRent + tempMedicalAllowance;
        }
    }
}

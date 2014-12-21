using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        Salary aSalary = new Salary();
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            aSalary.name = employeeNameTextBox.Text;
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            aSalary.GetSalaryAmount();
            MessageBox.Show(aSalary.name + ", your salary is: " + aSalary.totalSalary + " TK.");
        }
    }
}

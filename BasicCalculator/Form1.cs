using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            
            cbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            
            float num1 = (float)Convert.ToDouble(txtNum1.Text);
            float num2 = (float)Convert.ToDouble(txtNum2.Text);

            
            string operatorChoice = cbOperator.Text;

          
            float totalResult = 0;

            
            if (operatorChoice == "+")
            {
                totalResult = BasicComputation.Addition(num1, num2);
            }
            else if (operatorChoice == "-")
            {
                totalResult = BasicComputation.Subtraction(num1, num2);
            }
            else if (operatorChoice == "*")
            {
                totalResult = BasicComputation.Multiplication(num1, num2);
            }
            else if (operatorChoice == "/")
            {
                totalResult = BasicComputation.Division(num1, num2);
            }

          
            lblTotal.Text = totalResult.ToString();
        }
    }
}
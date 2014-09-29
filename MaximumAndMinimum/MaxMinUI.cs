using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaximumAndMinimum
{
    public partial class MaxMinForm : Form
    {
        public MaxMinForm()
        {
            InitializeComponent();

        }

        
        private void maximumButton_Click(object sender, EventArgs e)
        {
            List<int> number = inputAndSort();
            meximumLabel.Text = "Mazimum Number is = " + Convert.ToString(number[4]);
        }

        private void minimumButton_Click(object sender, EventArgs e)
        {
            List<int> number = inputAndSort();
            minimumLabel.Text = "Mimum Number is = " + Convert.ToString(number[0]);
        }
        private List<int> inputAndSort()
        {
            List<int> number = new List<int>();
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int thiredNumber = Convert.ToInt32(thiredNumberTextBox.Text);
            int fourthNumber = Convert.ToInt32(fourthNumberTextBox.Text);
            int fifthNumber = Convert.ToInt32(fifthNumberTextBox.Text);   

            number.Add(firstNumber);
            number.Add(secondNumber);
            number.Add(thiredNumber);
            number.Add(fourthNumber);
            number.Add(fifthNumber);

            number.Sort();
            return number;
        }

        



      
    }
}

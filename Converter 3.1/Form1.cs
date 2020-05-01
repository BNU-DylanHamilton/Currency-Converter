using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_3._1
{
    public partial class converterForm : Form
    {
        private double amount, dollars, euros, rupees;
        private DialogResult quit;

        public converterForm()
        {
            InitializeComponent();
            convertedLabel.Text = "";
            dollars = 1.8;
            euros = 1.4;
            rupees = 80;
        }

        /// <summary>
        /// This method only proceeds with 
        /// closing the program if the user
        /// selects 'Yes' in the message box.
        /// </summary>
        private void closeConverter(object sender, EventArgs e)
        {
            quit = MessageBox.Show("Are you sure you want to quit?", "Check", MessageBoxButtons.YesNo);

            if(quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This method converts inputted amount
        /// to Dollars.
        /// </summary>
        private void dollarsConversion(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(poundsTextBox.Text) * dollars;
            convertedLabel.Text = amount.ToString("0.00") + " Dollars";
        }

        /// <summary>
        /// This method converts inputted amount
        /// to Euros.
        /// </summary>
        private void eurosConversion(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(poundsTextBox.Text) * euros;
            convertedLabel.Text = amount.ToString("0.00") + " Euros";
        }

        /// <summary>
        /// This method converts inputted amount
        /// to Rupees.
        /// </summary>
        private void rupeesConversion(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(poundsTextBox.Text) * rupees;
            convertedLabel.Text = amount.ToString() + " Rupees";
        }
    }
}

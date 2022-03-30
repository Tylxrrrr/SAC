using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_SAC
{
    public partial class Form1 : Form
    {
        private double totalValue = 0f;
        private double bookValue = 0f;
        private int bookCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Check for zero purchase price
            if (purchasePriceNumUpDown.Value <= 0)
            {
                hintLabel.Text = "Please enter a purchase price greater than zero";
                return;
            } 
            else
            {
            // Calculate the total value of each book
            bookValue = calculateCurrentValue(Convert.ToDouble(purchasePriceNumUpDown.Value), Convert.ToDouble(ageNumUpDown.Value));
            totalValue = totalValue + bookValue;
            
            // Increment the count for books quoted
            bookCount++;

            // Display the calculated individual and total value of all books and the number of books 
            valueLabel.Text = String.Format("It is worth ${0}\nThe collection so far is worth ${1} ({2} book(s))", bookValue, totalValue, bookCount);
            }
        }


        private double calculateCurrentValue(double purchaseValue, double age)
        {
            // Calculate the depreciation value of each book
            double depreciation = purchaseValue * 0.2 * (Convert.ToInt64(age));
            if (depreciation > purchaseValue)
            {
                return 0f;
            }
            return purchaseValue - depreciation;
        }

        private void endQuoteButton_Click(object sender, EventArgs e)
        {
            // Reset all values to zero when the end quote button is pressed
            ageNumUpDown.Value = 0;
            purchasePriceNumUpDown.Value = 0;
            totalValue = 0f;
            bookValue = 0f;
            bookCount = 0;

            // Reset all labels 
            valueLabel.Text = "";
            hintLabel.Text = "Enter book(s) details for a quote";
        }
    }
}

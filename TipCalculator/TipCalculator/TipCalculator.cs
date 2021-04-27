using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
      Assignment - Tip Calculator
      Date       - 27-04-2021

                   Calculates the total amount of bill and tip to be paid per person
 */ 
namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxBill.TextChanged += TextBoxBill_TextChanged;                      //occurs when Bill is entered
            numericUpDownTip.ValueChanged += NumericUpDownTip_ValueChanged;          //occurs when Tip is entered
            numericUpDownPeople.ValueChanged += NumericUpDownPeople_ValueChanged;    //occurs when Number of People is entered

        }
        
        private void Calculate()
        {

            // calculates and shows the amount of bill and tip to be paid by each person entered by the user
            
            double Bill;                                                   //amount of Bill
            int Tip;                                                       //amount of Tip
            int noOfPeople;                                                //number of people
            double tipPerPerson;                                           //amount of tipPerPerson
            double totalPerPerson;                                         //amount of total bill per person

            double.TryParse(textBoxBill.Text, out Bill);                   //assigning Bill variable to textBoxBill 
            Tip = Convert.ToInt32(numericUpDownTip.Value);                 //assigning Tip to numericUpDownTip
            noOfPeople = Convert.ToInt32(numericUpDownPeople.Value);       //assigning noOfPeople to numericUpDownPeople
            tipPerPerson = (Bill * Tip) / (noOfPeople * 100);              //calculating Tip to be paid by each person
            labelTip.Text = tipPerPerson.ToString("c");                    //showing Tip to be paid by each person
            totalPerPerson = (Bill / noOfPeople) + tipPerPerson;           //calculating Amount to be paid by each person
            labelTotal.Text = totalPerPerson.ToString("c");                //showing Amount to be paid by each person
        }
        
        private void TextBoxBill_TextChanged(object sender, EventArgs e)
        {
            //function for Bill box
            
            Calculate();                                                    //calculate function is called
        
        }

        private void NumericUpDownTip_ValueChanged(object sender, EventArgs e)
        {
            //function for Tip box

            if (numericUpDownTip.Value < 0)                                 //statement to check whether user enters negative tip  
            {
                numericUpDownTip.Value = 0;
                MessageBox.Show("Tip cannot be negative!");
            }
            if (numericUpDownTip.Value > 100)                               //statement to check whether user enters tip out of maximum limit
            {
                numericUpDownTip.Value = 0;              
                MessageBox.Show("Maximum Tip reached!");
            }
            Calculate();

        }

        private void NumericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {
            //function for Number of People Box
            
            if (numericUpDownPeople.Value == 0)                             //statement to check whether user enters 0 number of people      
            {
                numericUpDownPeople.Value = 1;
                MessageBox.Show("Number of People cannot be 0!");
            }
            if (numericUpDownPeople.Value > 100)                            //statement to check whether user enters number of people out of maximum limit
            {
                numericUpDownPeople.Value = 1;
                MessageBox.Show("Maximum Occupancy Reached!");
            }
             Calculate();
        }
        private void textBoxBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            //function to accept only decimal whole numbers

            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&e.KeyChar!=46)       //statement to check whether user enters alpahbets or negative numbers in textBoxBill
            {
                MessageBox.Show("Accepts only numeric values");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //function to clear the labels and boxes
            
            textBoxBill.Clear();                                            
            numericUpDownTip.Value = 0;
            numericUpDownPeople.Value = 1;
            labelTip.Text.Remove(0);
            labelTotal.Text.Remove(0);
        }
    }
}

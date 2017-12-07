using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Model;

namespace WindowsFormsApp2
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrizeAmtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //Once a form is validated we can then populate it without having to convert text
            //using our constructor in the prize model
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text, 
                    PlaceNumberValue.Text, 
                    PrizeAmountValue.Text, 
                    PrizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                //Here we are clearing the form after it has been put in the database
                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }

            //If the form is invalid we will return a simple dialog box letting user know
            else
            {
                MessageBox.Show("The form has invalid information. Please check it and try again.");
            }
        }

        //The first thing we want to do is validate the first four fields in the form
        private bool ValidateForm()
        {
            bool output = true;

            //TryParse in this case it will take (string, out int) and return a bool value 
            //if the Parse worked to convert the string to an int
            //The following are parameters checking if the form is valid and returning a bool output
            int placeNumber = 0;
            bool placeNumberValueNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber );

            if (placeNumberValueNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal PrizeAmount = 0;
            double PrizePercentage = 0;

            //Use TryParse to make sure that PrizeAmount & PrizePercentage are valid numbers
            //Rather than someone putting "Three Hundred"

            bool PrizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out PrizeAmount);
            bool PrizePercentageValid = double.TryParse(PrizePercentageValue.Text, out PrizePercentage);

            if (PrizeAmountValid == false || PrizePercentageValid == false)
            {
                output = false;
            }

            if(PrizeAmount <= 0 && PrizePercentage <= 0)
            {
                output = false;
            }

            if(PrizePercentage < 0 || PrizePercentage > 100)
            {
                output = false;
            }

            return output;
        }


    }
}

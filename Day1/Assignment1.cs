using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Assignment1 : Form
    {
        public Assignment1()
        {
            InitializeComponent();

            #region Old solution if there are errors the error is printed
            //this.buttonConvert.Click += buttonConvert_Click; 
            #endregion

            // Subscribe to text change event for value input
            this.textBoxValue.TextChanged += InputFieldsChanged;

            // Subscribe to radio button change events
            this.radioButtonMeterToKilometer.CheckedChanged += InputFieldsChanged;
            this.radioButtonMeterToMile.CheckedChanged += InputFieldsChanged;
            this.radioButtonMileToMeter.CheckedChanged += InputFieldsChanged;

            // Initially disable the Convert button
            this.buttonConvert.Enabled = false;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

            decimal validationValue = decimal.Parse(textBoxValue.Text);

            if (radioButtonMeterToKilometer.Checked)
            {
                textBoxResult.Text = (validationValue / 1000).ToString();
            }
            else if (radioButtonMeterToMile.Checked)
            {
                textBoxResult.Text = (validationValue * 1000).ToString();  // Meters to miles
            }
            else if (radioButtonMileToMeter.Checked)
            {
                textBoxResult.Text = (validationValue / 1000).ToString();  // Miles to meters
            }

            #region Old solution if there are errors the error is printed
            //ErrorInputValue.Visible = false;
            //ErrorInputChooseUint.Visible = false;

            //if (string.IsNullOrEmpty(textBoxValue.Text))
            //{
            //    ErrorInputValue.Text = "Require Enter Number";
            //    ErrorInputValue.Visible = true;
            //    return;
            //}

            //if (!decimal.TryParse(textBoxValue.Text, out decimal validationValue))
            //{
            //    ErrorInputValue.Text = "Must Be Number";
            //    ErrorInputValue.Visible = true;
            //    return;
            //}


            //if (!radioButtonMeterToKilometer.Checked && !radioButtonMeterToMile.Checked && !radioButtonMileToMeter.Checked)
            //{
            //    ErrorInputChooseUint.Text = "Require Choose Unit";
            //    ErrorInputChooseUint.Visible = true;
            //    return;
            //} 
            #endregion

        }



        private void InputFieldsChanged(object sender, EventArgs e)
        {
            // Check if the input value is a valid number
            bool isValidNumber = decimal.TryParse(textBoxValue.Text, out _);

            // Check if any of the radio buttons is selected
            bool isUnitSelected = radioButtonMeterToKilometer.Checked ||
                                  radioButtonMeterToMile.Checked ||
                                  radioButtonMileToMeter.Checked;

            // Enable the Convert button if both a valid number and a unit are selected
            buttonConvert.Enabled = isValidNumber && isUnitSelected;

        }
    }
}

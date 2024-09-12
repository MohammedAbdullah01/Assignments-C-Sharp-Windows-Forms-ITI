using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }


        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();

            bool isValid = ValidateName() & ValidateEmail() & ValidateGender() & ValidateFavoriteSport();

            if (isValid)
            {
                LabelMsgSucceededRegistration.Text = "Thank You.. Your Registration Is Valid :)";
                LabelMsgSucceededRegistration.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }

        private bool ValidateName()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                LabelErrorInputName.Text = "Require Input Name";
                return false;
            }

            if (!Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z]+$"))
            {
                LabelErrorInputName.Text = "Require Name Must Be Characters only";
                return false;
            }

            if (textBoxName.Text.Length < 3)
            {
                LabelErrorInputName.Text = "Name Must Contain at Least 3 Characters :(";
                return false;
            }

            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                LabelErrorInputEmail.Text = "Require Input Email.";
                return false;
            }


            if (!Regex.IsMatch(textBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                LabelErrorInputEmail.Text = "Please enter a valid email address.";
                return false;
            }

            return true;
        }

        private bool ValidateGender()
        {
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                LabelErrorInputGender.Text = "Choose at Least One Gender :(";
                return false;
            }
            return true;
        }

        private bool ValidateFavoriteSport()
        {
            if (!CheckBoxFootball.Checked && !CheckBoxTennis.Checked && !CheckBoxSwimming.Checked)
            {
                LabelErrorInputFavoriteSport.Text = "Choose at Least One Favorite Sport :(";
                return false;
            }
            return true;
        }

        private void ClearErrorLabels()
        {
            LabelErrorInputName.Text = "";
            LabelErrorInputEmail.Text = "";
            LabelErrorInputGender.Text = "";
            LabelErrorInputFavoriteSport.Text = "";
            LabelMsgSucceededRegistration.Text = "";
        }
    }
}

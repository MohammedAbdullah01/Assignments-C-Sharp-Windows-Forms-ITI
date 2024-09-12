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

namespace Day2
{
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();

            //string[] row1 = { "John", "30", "1/1/2020" };
            //string[] row2 = { "Mary", "25", "2/2/2022" };
            //string[] row3 = { "Steve", "40", "3/3/2023" };

            //ListViewItem item1 = new ListViewItem(row1),
            //             item2 = new ListViewItem(row2),
            //             item3 = new ListViewItem(row3);

            //listViewData.Items.Add(item1);
            //listViewData.Items.Add(item2);
            //listViewData.Items.Add(item3);


        }

        private bool ValidatedInputName()
        {
            if(string.IsNullOrEmpty(textBoxName.Text))
            {
                labelErrorInputName.Text = "Require Input Name";
                return false;
            }

            if (textBoxName.Text.Length < 3 )
            {
                labelErrorInputName.Text = "Require Input Name Greater Then Or Equal 3 ";
                return false;
            }

            if (!Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z]+$"))
            {
                labelErrorInputName.Text = "Require Name Must Be Characters only";
                return false;
            }

            return true;
        }

        private bool ValidatedInputPhone()
        {
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                labelErrorInputPhone.Text = "Require Input Phone Number";
                return false;
            }

            if (!Regex.IsMatch(textBoxPhone.Text, "^[0-9]\\d{2}-\\d{4}-\\d{4}"))
            {
                labelErrorInputPhone.Text = "Require Phone Must Be Numbers only And (-) Example (###-####-####)";
                return false;
            }

            return true;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            bool isValid = ValidatedInputName() & ValidatedInputPhone();

            if (isValid)
            {
                string[] newItem = { textBoxName.Text, textBoxPhone.Text, dateTimeBirthdate.Value.ToString("dd/MM/yyyy") };
                ListViewItem listViewItem = new ListViewItem(newItem);
                listViewData.Items.Add(listViewItem);

                ClearForm();
            }
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(listViewData.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewData.SelectedItems[0];
                textBoxName.Text = selectedItem.SubItems[0].Text;
                textBoxPhone.Text = selectedItem.SubItems[1].Text;
                dateTimeBirthdate.Value = DateTime.Parse(selectedItem.SubItems[2].Text);
                buttonAddItem.Enabled = false;
            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {

            ClearErrorMessages();

            if (listViewData.SelectedItems.Count == 0)
            {
                labelErrorListView.Text = "Please select an item to Update.";
                return;
            }

            bool isValid = ValidatedInputName() & ValidatedInputPhone();

            if (isValid)
            {
                ListViewItem selectedItem = listViewData.SelectedItems[0];

                selectedItem.SubItems[0].Text = textBoxName.Text;
                selectedItem.SubItems[1].Text = textBoxPhone.Text;
                selectedItem.SubItems[2].Text = dateTimeBirthdate.Value.ToString("dd/MM/yyyy");

                ClearForm();
            }
        }


        private void ClearErrorMessages()
        {
            labelErrorInputName.Text = "";
            labelErrorInputPhone.Text = "";
            labelErrorInputBirthDate.Text = "";
            labelErrorListView.Text = "";
        }


        private void ClearForm()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            dateTimeBirthdate.Value = DateTime.Now;
            buttonAddItem.Enabled = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            if (listViewData.SelectedItems.Count == 0)
            {
                labelErrorListView.Text = "Please select an item to Remove.";
                return;
            }

            bool isValid = ValidatedInputName() & ValidatedInputPhone();

            if (isValid)
            {
                ListViewItem selectedItem = listViewData.SelectedItems[0];
                selectedItem.Remove();

                ClearForm();
            }
        }
    }
}

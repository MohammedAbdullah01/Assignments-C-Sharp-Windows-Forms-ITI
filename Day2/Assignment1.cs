using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Assignment1 : Form
    {
        Dictionary<string, List<string>> labTrainees = new Dictionary<string, List<string>>();

        List<string> trainees;
        public Assignment1()
        {
            InitializeComponent();

            trainees = new List<string> 
            {
                "Mohamed",
                "Ahmed",
                "Ali",
                "Osama",
                "Rayyan",
                "Noah"
            };

            checkedListBoxTrainees.Items.AddRange(trainees.ToArray());

            labTrainees.Add("Lab1", new List<string>());
            labTrainees.Add("Lab2", new List<string>());
            labTrainees.Add("Lab3", new List<string>());

            comboBoxLab.SelectedIndex = comboBoxLab.Items.Count > 0 ?  0 : -1;


        }

        private void buttonMoveSelector_Click(object sender, EventArgs e)
        {
            string selectedLab = comboBoxLab.SelectedItem?.ToString();

            if(!string.IsNullOrEmpty(selectedLab) && labTrainees.ContainsKey(selectedLab))
            {
                MoveSelectedItems(checkedListBoxTrainees , labTrainees[selectedLab]);

                RefreshLabCheckedListBox();
            }

            else
            {
                MessageBox.Show("Please select a lab first");
            }
        }

        
        private void buttonReturnSpecified_Click(object sender, EventArgs e)
        {
            string selectedLab = comboBoxLab.SelectedItem?.ToString();

            var checkedItems = checkedListBoxLab.CheckedItems.Cast<object>().ToList();

            foreach (var item in checkedItems)
            {
                checkedListBoxTrainees.Items.Add(item);
                labTrainees[selectedLab].Remove(item.ToString());
            };

            RefreshLabCheckedListBox();
        }


        private void buttonMoveSelectorAll_Click(object sender, EventArgs e)
        {
            string selectedLab = comboBoxLab.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedLab) && labTrainees.ContainsKey(selectedLab))
            {
                MoveAllItems(checkedListBoxTrainees, labTrainees[selectedLab]);
                RefreshLabCheckedListBox();
            }
            else
            {
                MessageBox.Show("Please select a lab first");
            }
        }


        private void buttonReturnSpecifiedAll_Click(object sender, EventArgs e)
        {

            string selectedLab = comboBoxLab.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedLab) && labTrainees.ContainsKey(selectedLab))
            {
                checkedListBoxTrainees.Items.AddRange(labTrainees[selectedLab].ToArray());
                labTrainees[selectedLab].Clear();
                RefreshLabCheckedListBox();
            }
            else
            {
                MessageBox.Show("Please select a lab first");
            }

        }


        private void RefreshLabCheckedListBox()
        {
            string selectedLab = comboBoxLab.SelectedItem?.ToString();

            checkedListBoxLab.Items.Clear();

            if(labTrainees.ContainsKey(selectedLab))
            {
                checkedListBoxLab.Items.AddRange(labTrainees[selectedLab].ToArray());
            }
        }


        private void comboBoxLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLabCheckedListBox();
        }


        private void MoveSelectedItems(CheckedListBox fromList, List<string> toList)
        {
            var checkedItems = fromList.CheckedItems.Cast<object>().ToList();

            foreach (var item in checkedItems)
            {
                toList.Add(item.ToString());
                fromList.Items.Remove(item);
            };
        }


        private void MoveAllItems(CheckedListBox fromList, List<string> toList)
        {
            var allItems = fromList.Items.Cast<string>().ToList();

            foreach (var item in allItems)
            {
                toList.Add(item);
            }

            fromList.Items.Clear();
        }

    }
}

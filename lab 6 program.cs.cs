using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListArrayListDemoApp
{
    public partial class Form1 : Form
    {
        // Declare both List and ArrayList
        private List<string> listItems = new List<string>();
        private ArrayList arrayListItems = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        // Button to add item to selected collection
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = textBoxInput.Text.Trim();
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please enter an item to add.");
                return;
            }

            // Add item to the selected collection
            if (comboBoxCollection.SelectedItem.ToString() == "List")
            {
                listItems.Add(item);
            }
            else if (comboBoxCollection.SelectedItem.ToString() == "ArrayList")
            {
                arrayListItems.Add(item);
            }

            UpdateListBox();
            textBoxInput.Clear();
        }

        // Button to remove selected item from the collection
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                string selectedItem = listBoxItems.SelectedItem.ToString();

                // Remove selected item from the appropriate collection
                if (comboBoxCollection.SelectedItem.ToString() == "List")
                {
                    listItems.Remove(selectedItem);
                }
                else if (comboBoxCollection.SelectedItem.ToString() == "ArrayList")
                {
                    arrayListItems.Remove(selectedItem);
                }

                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        // Button to clear the list/ArrayList
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (comboBoxCollection.SelectedItem.ToString() == "List")
            {
                listItems.Clear();
            }
            else if (comboBoxCollection.SelectedItem.ToString() == "ArrayList")
            {
                arrayListItems.Clear();
            }

            UpdateListBox();
        }

        // Update the ListBox with current items in the selected collection
        private void UpdateListBox()
 

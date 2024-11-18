using System;
using System.Windows.Forms;

namespace WindowsFormsControlsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a MessageBox", "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLabelTest_Click(object sender, EventArgs e)
        {
            labelTest.Text = "New Text for Label!";
        }

        private void textBoxTest_TextChanged(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = textBoxTest.Text;
        }

        
        private void checkBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTest.Checked)
                MessageBox.Show("Checkbox is Checked");
            else
                MessageBox.Show("Checkbox is Unchecked");
        }

        
        private void radioButtonTest_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTest.Checked)
                MessageBox.Show("RadioButton is Selected");
        }

        private void comboBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected item: {comboBoxTest.SelectedItem}");
        }

        
        private void numericUpDownTest_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Numeric Value: {numericUpDownTest.Value}");
        }

        private void dateTimePickerTest_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected Date: {dateTimePickerTest.Value.ToShortDateString()}");
        }

       
        private void monthCalendarTest_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"Selected Month: {monthCalendarTest.SelectionStart.ToString("MMMM yyyy")}");
        }

       
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            pictureBoxTest.ImageLocation = @"C:\path\to\your\image.jpg"; // Change path as necessary
            pictureBoxTest.Load();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void sayHiButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                PromptUserInput(firstNameTextBox, firstNameLabel);
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                PromptUserInput(lastNameTextBox, lastNameLabel);
            }
            else
            {
                MessageBox.Show($"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}");
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                firstNameTextBox.Focus();
            }
        }

        public void PromptUserInput(TextBox textBox, Label label)
        {
            MessageBox.Show($"Please enter information for {label.Text} field.",
                "Blank Field Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Text = "";
            textBox.Focus();
        }
    }
}

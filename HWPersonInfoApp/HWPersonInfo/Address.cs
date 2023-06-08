using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPersonInfo
{
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        private void saveAddressButton_Click(object sender, EventArgs e)
        {
            bool isBlankField = false;

            if (string.IsNullOrWhiteSpace(streetAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(cityTextBox.Text) ||
                string.IsNullOrWhiteSpace(stateTextBox.Text) ||
                string.IsNullOrWhiteSpace(zipCodeTextBox.Text))
            {
                isBlankField = true;
            }

            if (isBlankField == true)
            {
                MessageBox.Show("Please enter information for all fields.", "Blank Field Detected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string address = $"{streetAddressTextBox.Text}, {cityTextBox.Text}, {stateTextBox.Text} {zipCodeTextBox.Text}";
                Dashboard.addresses.Add(address);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

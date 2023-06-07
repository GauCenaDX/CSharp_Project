using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        // Object without an access modifier is private by default.
        // Binding List has a feature to notify others when it's changed.
        BindingList<string> messages = new BindingList<string>();
        
        public Dashboard()
        {
            InitializeComponent();

            WireUpList();
        }

        public void WireUpList()
        {
            messageListBox.DataSource = messages;

            // To select which property of a class instance to display in a List Box
            //messageListBox.DisplayMember = nameof(Dashboard.Text);
        }

        private void addMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list",
                    "Blacnk Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageTextBox.Text);
                messageTextBox.Text = "";
            }
            messageTextBox.Focus();
        }
    }
}

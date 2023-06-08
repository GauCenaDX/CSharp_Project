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
    public partial class Dashboard : Form
    {
        internal static BindingList<string> addresses = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();

            WireUpList();
        }

        public void WireUpList()
        { 
            addressesListBox.DataSource = addresses;
        }
        private void addAddressButton_Click(object sender, EventArgs e)
        {
            Address addressForm = new Address();
            addressForm.Show();
        }
    }
}

using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            //addresses.Add(new AddressModel { StreetAddress = "123 State Street", City = "Scranton", State = "CA", ZipCode = "12345" });

            // WinForm will display the ToString() of an object ==> specify how object should be displayed
            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void addNewAddress_Click(object sender, EventArgs e)
        {
            // Open the Address Entry form
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked, //-- bool CheckBox.Checked { get; set; }
                Addresses = addresses.ToList()
            };

            // We can then do something with this person object
        }
    }
}

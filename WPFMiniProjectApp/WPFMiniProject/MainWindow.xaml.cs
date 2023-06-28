using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public MainWindow()
        {
            InitializeComponent();

            addressesList.ItemsSource = addresses;

            //addresses.Add(new AddressModel
            //{ 
            //    StreetAddress = "123 Wallabee Way",
            //    City = "Clarks Summit",
            //    State = "PA",
            //    ZipCode = "18411"
            //});
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void AddAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        private void SavePerson_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = (activeCheckBox.IsChecked ?? false), //-- null coalescing operator
                Addresses = addresses.ToList()
            };
        }
    }
}

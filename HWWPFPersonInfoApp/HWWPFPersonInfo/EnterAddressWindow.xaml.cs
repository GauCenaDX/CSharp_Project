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
using System.Windows.Shapes;

namespace HWWPFPersonInfo
{
    /// <summary>
    /// Interaction logic for EnterAddressWindow.xaml
    /// </summary>
    public partial class EnterAddressWindow : Window
    {
        BindingList<string> _addresses;
        public EnterAddressWindow(BindingList<string> addresses)
        {
            InitializeComponent();

            _addresses = addresses;
        }

        private void SaveAddressButton_Click(object sender, RoutedEventArgs e)
        {
            string address = $"{streetTextBox.Text}, {cityTextBox.Text}, " +
                $"{stateTextBox.Text} {zipCodeTextBox.Text}";

            _addresses.Add(address);

            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipCodeTextBox.Text = "";

            this.Close();
        }
    }
}

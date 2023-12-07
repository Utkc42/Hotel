using Hotel.Presentation.Customer.Model;
using System;
using System.Collections.Generic;
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

namespace Hotel.Presentation.Customer.WindowsOrganisor
{
    /// <summary>
    /// Interaction logic for PriceInfoWindow.xaml
    /// </summary>
    public partial class PriceInfoWindow : Window
    {
        public PriceInfoUI PriceInfoUI { get; set; }
        public PriceInfoWindow()
        {
            InitializeComponent();
        }

        public PriceInfoWindow(PriceInfoUI priceInfoUI)
        {
            PriceInfoUI = priceInfoUI;
            InitializeComponent();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
           
            
            if (IsFormatValid())
            {

                if (MemberUI == null)
                {
                    //Nieuw
                    //wegschrijven
                    //TODO nrofmembers

                    string name = NameTextBox.Text;
                    string birthDate = BirthDayTextBox.Text;
                    MemberUI = new MemberUI(name, birthDate);


                }

                else
                {
                    //Update
                    //update DB
                    MemberUI.Name = NameTextBox.Text;
                    MemberUI.BirthDate = BirthDayTextBox.Text;


                }
                DialogResult = true;

                Close();
            }
            
        }
        public bool IsFormatValid()
        {
            int adultPrice;
            int childPrice;
            int discount;
            int adultAge;
            if (!int.TryParse(AdultPriceTextBox.Text, out adultPrice))
            {
                MessageBox.Show("Adult Price is not a number");
                return false;
            }
            else if (!int.TryParse(ChildPriceTextBox.Text, out childPrice))
            {
                MessageBox.Show("Adult Price is not a number");
                return false;
            }
            else if (!int.TryParse(DiscountTextBox.Text, out discount))
            {
                MessageBox.Show("Adult Price is not a number");
                return false;
            }
            else if (!int.TryParse(AdultAgeTextBox.Text, out adultAge))
            {
                MessageBox.Show("Adult Price is not a number");
                return false;
            }
            else
            {
                return true;
            }
            
       

        }
    }
}

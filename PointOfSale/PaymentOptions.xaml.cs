using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using System.Globalization;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        private OrderMenu orderMenu
        {
            get
            {
                DependencyObject parent = this;
                do
                {
                    // Get this node's parent
                    parent = LogicalTreeHelper.GetParent(parent);
                }
                // Invariant: there is a parent element, and it is not a ListSwitcher 
                while (!(parent is null || parent is OrderMenu));
                return parent as OrderMenu;
            }
        }

        public PaymentOptions()
        {
            InitializeComponent();
            btnReturn.Click += ReturnClick;
        }

        void ReturnClick(object sender, RoutedEventArgs e)
        {
            orderMenu.DisOrEnableButtons(true);
            orderMenu.menuBorder.Child = null;
        }

        private void btnCredDeb_Click(object sender, RoutedEventArgs e)
        {
            Order order = orderMenu.Order; 
            switch (CardReader.RunCard(order.Total))
            {
                case CardTransactionResult.Approved:
                    MessageBox.Show("Card Approved!");
                    RecieptPrinter.PrintLine("Order #" + order.Number.ToString());
                    RecieptPrinter.PrintLine(DateTime.Now.ToString() + "\n");
                    foreach (IOrderItem io in order) 
                    {
                        RecieptPrinter.PrintLine(io.ToString() + "\t" + io.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                        foreach (string str in io.SpecialInstructions)
                            RecieptPrinter.PrintLine(str);
                    }
                    RecieptPrinter.PrintLine("\nSubtotal: " + order.Subtotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    RecieptPrinter.PrintLine("Tax: " + order.Tax.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    RecieptPrinter.PrintLine("Total: " + order.Total.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    RecieptPrinter.PrintLine("Payment Method: Card");
                    RecieptPrinter.CutTape();                   
                    orderMenu.NewOrder();
                    break;
                default:
                    MessageBox.Show("Transaction Failed");
                    break;
            }
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            orderMenu.menuBorder.Child = new Drawer(orderMenu);
        }
    }
}

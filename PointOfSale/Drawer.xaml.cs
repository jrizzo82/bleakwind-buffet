/*
 * Author: Jerry Rizzo 
 * Class Name: Drawer.xaml.cs
 * Purpose: Represents the View for the CashDrawer
 */
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Drawer.xaml
    /// </summary>
    public partial class Drawer : UserControl
    {
        private OrderMenu orderMenu;
        //{
        //    get
        //    {
        //        DependencyObject parent = this;
        //        do
        //        {
        //            // Get this node's parent
        //            parent = LogicalTreeHelper.GetParent(parent);
        //        }
        //        // Invariant: there is a parent element, and it is not an OrderMenu 
        //        while (!(parent is null || parent is OrderMenu));
        //        return parent as OrderMenu;
        //    }
        //}

    private CashOrderViewModel cvm;

        /// <summary>
        /// Custructor for Drawer
        /// </summary>
        public Drawer(OrderMenu om)
        {
            InitializeComponent();
            orderMenu = om;
            cvm = new CashOrderViewModel();
            DataContext = cvm;
            Hundreds.ValueChanged += CashCounter_ValueChanged;
            Fifties.ValueChanged += CashCounter_ValueChanged;
            Twenties.ValueChanged += CashCounter_ValueChanged;
            Tens.ValueChanged += CashCounter_ValueChanged;
            Fives.ValueChanged += CashCounter_ValueChanged;
            Ones.ValueChanged += CashCounter_ValueChanged;
            Twos.ValueChanged += CashCounter_ValueChanged;
            DollarCoins.ValueChanged += CashCounter_ValueChanged;
            FiftyCents.ValueChanged += CashCounter_ValueChanged;
            Quarters.ValueChanged += CashCounter_ValueChanged;
            Dimes.ValueChanged += CashCounter_ValueChanged;
            Nickels.ValueChanged += CashCounter_ValueChanged;
            Pennies.ValueChanged += CashCounter_ValueChanged;
            cvm.OrderTotal = orderMenu.Order.Total;
            cvm.SetAmountDue();
        }

        /// <summary>
        /// Handles clicking the return to order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            orderMenu.DisOrEnableButtons(true);
            orderMenu.menuBorder.Child = null;
        }

        /// <summary>
        /// Handles clicking the finalize order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalize_Click(object sender, RoutedEventArgs e)
        {
            if(cvm.Finalize(orderMenu.Order))
                orderMenu.NewOrder();
        }

        /// <summary>
        /// Handles when a cash counter's value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashCounter_ValueChanged(object sender, RoutedEventArgs e)
        {
            //cvm.OrderTotal = orderMenu.Order.Total;
            cvm.CalculateChange();
        }
    }
}

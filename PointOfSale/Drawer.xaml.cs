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

        public Drawer()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            orderMenu.DisOrEnableButtons(true);
            orderMenu.menuBorder.Child = null;
        }
    }
}

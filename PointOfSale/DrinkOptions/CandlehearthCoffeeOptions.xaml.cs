/*
 * Author: Jerry Rizzo 
 * Class Name: CandlehearthCoffeeOptions.xaml.cs
 * Purpose: Represents the option menu for CandlehearthCoffee
 */

using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.DrinkOptions
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffeeOptions.xaml
    /// </summary>
    public partial class CandlehearthCoffeeOptions : UserControl
    {
        /// <summary>
        /// Constructor for CandlehearthCoffeeOptions
        /// </summary>
        public CandlehearthCoffeeOptions()
        {
            InitializeComponent();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            DataContext = cc;
            chkbxIce.DataContext = cc.Ice;
            chkbxCream.DataContext = cc.RoomForCream;
            chkbxDecaf.DataContext = cc.Decaf;
            rbtnSmall.DataContext = cc.Size;
            rbtnMedium.DataContext = cc.Size;
            rbtnLarge.DataContext = cc.Size;
        }
    }
}

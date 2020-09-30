/*
 * Author: Jerry Rizzo 
 * Class Name: MarkarthMilkOptions.xaml.cs
 * Purpose: Represents the option menu for MarkarthMilk
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
    /// Interaction logic for MarkarthMilkOptions.xaml
    /// </summary>
    public partial class MarkarthMilkOptions : UserControl
    {
        /// <summary>
        /// Constructor for MarkarthMilkOptions
        /// </summary>
        public MarkarthMilkOptions()
        {
            InitializeComponent();
            MarkarthMilk mm = new MarkarthMilk();
            DataContext = mm;
            chkbxIce.DataContext = mm.Ice;
            rbtnSmall.DataContext = mm.Size;
            rbtnMedium.DataContext = mm.Size;
            rbtnLarge.DataContext = mm.Size;
        }
    }
}

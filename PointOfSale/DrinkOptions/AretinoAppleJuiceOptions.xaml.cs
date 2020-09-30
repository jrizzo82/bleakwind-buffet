/*
 * Author: Jerry Rizzo 
 * Class Name: AretinoAppleJuiceOptions.xaml.cs
 * Purpose: Represents the option menu for AretinoAppleJuice
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
    /// Interaction logic for AretinoAppleJuiceOptions.xaml
    /// </summary>
    public partial class AretinoAppleJuiceOptions : UserControl
    {
        /// <summary>
        /// Constructor for AretinoAppleJuiceOptions
        /// </summary>
        public AretinoAppleJuiceOptions()
        {
            InitializeComponent();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DataContext = aj;
            chkbxIce.DataContext = aj.Ice;
            rbtnSmall.DataContext = aj.Size;
            rbtnMedium.DataContext = aj.Size;
            rbtnLarge.DataContext = aj.Size;
        }
    }
}

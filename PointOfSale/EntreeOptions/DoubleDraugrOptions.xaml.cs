/*
 * Author: Jerry Rizzo 
 * Class Name: DoubleDraugrOptions.xaml.cs
 * Purpose: Represents the option menu for DoubleDraugr
 */

using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.EntreeOptions
{
    /// <summary>
    /// Interaction logic for DoubleDraugrOptions.xaml
    /// </summary>
    public partial class DoubleDraugrOptions : UserControl
    {
        /// <summary>
        /// Constructor for DoubleDraugrOptions
        /// </summary>
        public DoubleDraugrOptions()
        {
            InitializeComponent();
            DoubleDraugr dd = new DoubleDraugr();
            DataContext = dd;
        }
    }
}

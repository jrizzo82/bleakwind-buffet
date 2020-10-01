/*
 * Author: Jerry Rizzo 
 * Class Name: WarriorWaterOptions.xaml.cs
 * Purpose: Represents the option menu for WarriorWater
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
    /// Interaction logic for WarriorWaterOptions.xaml
    /// </summary>
    public partial class WarriorWaterOptions : UserControl
    {
        /// <summary>
        /// Constructor for WarriorWaterOptions
        /// </summary>
        public WarriorWaterOptions()
        {
            InitializeComponent();
            WarriorWater ww = new WarriorWater();
            DataContext = ww;
           }
    }
}

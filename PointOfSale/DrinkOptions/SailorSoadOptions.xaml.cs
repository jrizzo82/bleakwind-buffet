﻿using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Jerry Rizzo 
 * Class Name: SailorSoadOptions.xaml.cs
 * Purpose: Represents the option menu for SailorSoad
 */

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
    /// Interaction logic for SailorSoadOptions.xaml
    /// </summary>
    public partial class SailorSoadOptions : UserControl
    {
        /// <summary>
        /// Constructor for SailorSoadOptions
        /// </summary>
        public SailorSoadOptions()
        {
            InitializeComponent();
            SailorSoda ss = new SailorSoda();
            DataContext = ss;
            chkbxIce.DataContext = ss.Ice;
            rbtnSmall.DataContext = ss.Size;
            rbtnMedium.DataContext = ss.Size;
            rbtnLarge.DataContext = ss.Size;
            rbtnBlackberry.DataContext = ss.Flavor;
            rbtnCherry.DataContext = ss.Flavor;
            rbtnPeach.DataContext = ss.Flavor;
            rbtnGrapefruit.DataContext = ss.Flavor;
            rbtnLemon.DataContext = ss.Flavor;
            rbtnWatermelon.DataContext = ss.Flavor;
        }
    }
}

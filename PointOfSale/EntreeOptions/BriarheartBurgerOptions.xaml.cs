/*
 * Author: Jerry Rizzo 
 * Class Name: BriarheartBurgerOptions.xaml.cs
 * Purpose: Represents the option menu for BriarheartBurger
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
    /// Interaction logic for BriarheartBurgerOptions.xaml
    /// </summary>
    public partial class BriarheartBurgerOptions : UserControl
    {
        /// <summary>
        /// Constructor for BriarheartBurgerOptions
        /// </summary>
        public BriarheartBurgerOptions()
        {
            InitializeComponent();
            BriarheartBurger bb = new BriarheartBurger();
            DataContext = bb;
        }
    }
}

/*
 * Author: Jerry Rizzo 
 * Class Name: ComboOptions.xaml.cs
 * Purpose: Represents the option menu for a Combo
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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboOptions.xaml
    /// </summary>
    public partial class ComboOptions : UserControl
    {
        public Combo Combo;

        public ComboOptions(Combo combo)
        {
            InitializeComponent();
            Combo = combo;
            DataContext = Combo;
        }

        public void SetOptionScreen(UserControl uc)
        {
            optBorder.Child = uc;
        }
    }
}

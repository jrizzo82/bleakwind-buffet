/*
 * Author: Jerry Rizzo 
 * Class Name: Drink.cs
 * Purpose: Represents drinks on the Bleakwind Buffet Menu
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        /// <value>enum value of item's size</value>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Price of the item
        /// </summary>
        /// <value>price in US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in each item
        /// </summary>
        /// <value>calories in Calories</value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for each item
        /// </summary>
        /// <value>list of instructions</value>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// A description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name
        {
            get
            {
                return ToString();
            }
        }   

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}

/*
 * Author: Jerry Rizzo 
 * Class Name: Side.cs
 * Purpose: Represents sides on the Bleakwind Buffet Menu
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Size of each side
        /// </summary>
        /// <value>enum value of item's size</value>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Price of each side
        /// </summary>
        /// <value>price of the side in US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in each side
        /// </summary>
        /// <value>calories in Calories</value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for each item
        /// </summary>
        /// <value>list of instructions</value>
        public abstract List<string> SpecialInstructions { get; }

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

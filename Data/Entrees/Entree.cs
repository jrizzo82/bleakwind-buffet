/*
 * Author: Jerry Rizzo 
 * Class Name: Entreecs
 * Purpose: Represents entrees on the Bleakwind Buffet Menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Price of the entree
        /// </summary>
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

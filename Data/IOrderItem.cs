/*
 * Author: Jerry Rizzo 
 * Class Name: IOrderItem.cs
 * Purpose: Interface for each menu item
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for the menu items
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {

        /// <summary>
        /// Price of the item
        /// </summary>
        /// <value>price in US dollars</value>
        double Price { get; }

        /// <summary>
        /// Calories in each item
        /// </summary>
        /// <value>calories in Calories</value>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions for each item
        /// </summary>
        /// <value>list of instructions</value>
        List<string> SpecialInstructions { get; }
    }
}

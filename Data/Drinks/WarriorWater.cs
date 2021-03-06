﻿/*
 * Author: Jerry Rizzo 
 * Class Name: WarriorWater.cs
 * Purpose: Represents Warrior Water drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Warrior Water drink.
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        private bool ice = true;
        private Size size = Size.Small;
        private bool lemon = false;

        /// <summary>
        /// A description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "It’s water. Just water.";
            }
        }

        /// <summary>
        /// The drink's price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.0;               
            }
        }

        /// <summary>
        /// The drink's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice
        {
            get
            {
                return this.ice;
            }
            set
            {
                if (this.ice != value)
                {
                    this.ice = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Ice"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the drink has lemon or not.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
            set
            {
                if (this.lemon != value)
                {
                    this.lemon = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Lemon"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// The drink's size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size != value)
                {
                    this.size = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Size"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                }
            }
        }

        /// <summary>
        /// List of special instructions.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> sInst = new List<string>();
                if (!this.ice)
                    sInst.Add("Hold ice");
                if (this.lemon)
                    sInst.Add("Add lemon");

                return sInst;
            }
        }

        /// <summary>
        /// The name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sub1;
            switch (this.size)
            {
                case Size.Small:
                    sub1 = "Small";
                    break;
                case Size.Medium:
                    sub1 = "Medium";
                    break;
                default:
                    sub1 = "Large";
                    break;
            }
            return sub1 + " Warrior Water";
        }
    }
}

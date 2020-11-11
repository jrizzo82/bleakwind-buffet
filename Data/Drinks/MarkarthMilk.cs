/*
 * Author: Jerry Rizzo 
 * Class Name: MarkarthMilk.cs
 * Purpose: Represents Markarth Milk Juice drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        private bool ice = false;
        private Size size = Size.Small;

        /// <summary>
        /// A description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Hormone-free organic 2% milk.";
            }
        }

        /// <summary>
        /// The drink's price.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    default:
                        return 1.22;
                }
            }
        }

        /// <summary>
        /// The drink's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 56;
                    case Size.Medium:
                        return 72;
                    default:
                        return 93;
                }
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
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
                if (this.ice)
                    sInst.Add("Add ice");

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
            return sub1 + " Markarth Milk";
        }
    }
}

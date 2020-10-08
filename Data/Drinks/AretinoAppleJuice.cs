/*
 * Author: Jerry Rizzo 
 * Class Name: AretinoAppleJuice.cs
 * Purpose: Represents Aretino Apple Juice drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool ice = false;
        private Size size = Size.Small;

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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    default:
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    default:
                        return 132;
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
            return sub1 + " Aretino Apple Juice";
        }
    }
}

/*
 * Author: Jerry Rizzo 
 * Class Name: PhillyPoacher.cs
 * Purpose: Represents Philly Poacher entree.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Philly Poacher entree.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Event handler for when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// Whether the entree is to have sirloin or not.
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return this.sirloin;
            }
            set
            {
                if (this.sirloin != value)
                {
                    this.sirloin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the entree is to have onion or not.
        /// </summary>
        public bool Onion
        {
            get
            {
                return this.onion;
            }
            set
            {
                if (this.onion != value)
                {
                    this.onion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the entree is to have a roll or not.
        /// </summary>
        public bool Roll
        {
            get
            {
                return this.roll;
            }
            set
            {
                if (this.roll != value)
                {
                    this.roll = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!this.sirloin)
                    sInst.Add("Hold sirloin");
                if (!this.onion)
                    sInst.Add("Hold onions");
                if (!this.roll)
                    sInst.Add("Hold roll");
               
                return sInst;
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

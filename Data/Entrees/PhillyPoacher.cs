/*
 * Author: Jerry Rizzo 
 * Class Name: PhillyPoacher.cs
 * Purpose: Represents Philly Poacher entree.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Philly Poacher entree.
    /// </summary>
    public class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// The entree price.
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public uint Calories
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
                this.sirloin = value;
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
                this.onion = value;
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
                this.roll = value;
            }
        }

        /// <summary>
        /// List of special instructions.
        /// </summary>
        public List<string> SpecialInstructions
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

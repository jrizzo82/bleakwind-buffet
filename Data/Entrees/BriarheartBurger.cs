/*
 * Author: Jerry Rizzo 
 * Class Name: BriarheartBurger.cs
 * Purpose: Represents the Briarheart Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Briarheart Burger entree.
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories 
        { 
            get
            {
                return 743;
            }
        }

        /// <summary>
        /// Whether the burger is to have a bun or not.
        /// </summary>
        public bool Bun
        {
            get 
            {
                return this.bun;
            }
            set
            {
                this.bun = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have ketchup or not.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return this.ketchup;
            }
            set
            {
                this.ketchup = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have mustard or not.
        /// </summary>
        public bool Mustard
        {
            get
            {
                return this.mustard;
            }
            set
            {
                this.mustard = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have pickle or not.
        /// </summary>
        public bool Pickle
        {
            get
            {
                return this.pickle;
            }
            set
            {
                this.pickle = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have cheese or not.
        /// </summary>
        public bool Cheese
        {
            get
            {
                return this.cheese;
            }
            set
            {
                this.cheese = value;
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
                if (!this.bun)
                    sInst.Add("Hold bun");
                if (!this.ketchup)
                    sInst.Add("Hold ketchup");
                if (!this.mustard)
                    sInst.Add("Hold mustard");
                if (!this.pickle)
                    sInst.Add("Hold pickle");
                if (!this.cheese)
                    sInst.Add("Hold cheese");

                return sInst;
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}

﻿/*
 * Author: Jerry Rizzo 
 * Class Name: BriarheartBurger.cs
 * Purpose: Represents the Briarheart Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
        /// A description of the item
        /// </summary>
        public override string Description
        { 
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }


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
                if (this.bun != value)
                {
                    this.bun = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Bun"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.ketchup != value)
                {
                    this.ketchup = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Ketchup"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.mustard != value)
                {
                    this.mustard = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Mustard"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.pickle != value)
                {
                    this.pickle = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Pickle"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.cheese != value)
                {
                    this.cheese = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Cheese"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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

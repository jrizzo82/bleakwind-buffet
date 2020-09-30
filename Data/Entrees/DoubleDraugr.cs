﻿/*
 * Author: Jerry Rizzo 
 * Class Name: DoubleDraugr.cs
 * Purpose: Represents Double Draugr entree.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Double Draugr entree.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

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
                return 7.32;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 843;
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the burger is to have tomato or not.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return this.tomato;
            }
            set
            {
                if (this.tomato != value)
                {
                    this.tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the burger is to have lettuce or not.
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return this.lettuce;
            }
            set
            {
                if (this.lettuce != value)
                {
                    this.lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the burger is to have mayo or not.
        /// </summary>
        public bool Mayo
        {
            get
            {
                return this.mayo;
            }
            set
            {
                if (this.mayo != value)
                {
                    this.mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
                if (!this.tomato)
                    sInst.Add("Hold tomato");
                if (!this.lettuce)
                    sInst.Add("Hold lettuce");
                if (!this.mayo)
                    sInst.Add("Hold mayo");

                return sInst;
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}

/*
 * Author: Jerry Rizzo 
 * Class Name: ThalmorTriple.cs
 * Purpose: Represents Thalmor Triple entree.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thalmor Triple entree.
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// A description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            }
        }

        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Tomato"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Lettuce"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Mayo"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the burger is to have bacon or not.
        /// </summary>
        public bool Bacon
        {
            get
            {
                return this.bacon;
            }
            set
            {
                if (this.bacon != value)
                {
                    this.bacon = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Bacon"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the burger is to have egg or not.
        /// </summary>
        public bool Egg
        {
            get
            {
                return this.egg;
            }
            set
            {
                if (this.egg != value)
                {
                    this.egg = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Egg"));
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
                if (!this.tomato)
                    sInst.Add("Hold tomato");
                if (!this.lettuce)
                    sInst.Add("Hold lettuce");
                if (!this.mayo)
                    sInst.Add("Hold mayo");
                if (!this.bacon)
                    sInst.Add("Hold bacon");
                if (!this.egg)
                    sInst.Add("Hold egg");

                return sInst;
            }
        }
        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

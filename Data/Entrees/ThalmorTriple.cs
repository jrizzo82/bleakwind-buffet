﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThalmorTriple
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
        /// The entree price.
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public uint Calories
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
                this.tomato = value;
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
                this.lettuce = value;
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
                this.mayo = value;
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
                this.bacon = value;
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
                this.egg = value;
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

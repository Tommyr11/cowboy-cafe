﻿///Author: Thomas Reece
///Project: CowboyCafe
///Class: DakotaDoubleBurger.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// To string for Dakota Double Burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
        private bool cheese = true;
        /// <summary>
        /// If the burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        private bool pickle = true;
        /// <summary>
        /// If the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        private bool tomato = true;
        /// <summary>
        /// If the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        private bool lettuce = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        /// <summary>
        /// The price of the double
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the double
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the double
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!bun) instructions.Add("hold bun");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!pickle) instructions.Add("hold pickle");
                if (!tomato) instructions.Add("hold tomato");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}

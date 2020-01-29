using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger
    {
        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool bun = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool Bun
        {
            get { return Bun; }
            set { Bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool Ketchup
        {
            get { return Ketchup; }
            set { Ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Mustard
        {
            get { return Mustard; }
            set { Mustard = value; }
        }
        private bool pickle = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Pickle
        {
            get { return Pickle; }
            set { Pickle = value; }
        }
        /// <summary>
        /// The price of the double
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the double
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the double
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold sour cream");
                if (!mustard) instructions.Add("hold green onions");
                if (!bun) instructions.Add("hold tortilla strips");
                if (!pickle) instructions.Add("hold pickle");
                

                return instructions;
            }
        }
    }
}

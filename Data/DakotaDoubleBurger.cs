using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
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
        private bool tomato = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool Tomato
        {
            get { return Tomato; }
            set { Tomato = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Mayo
        {
            get { return Mayo; }
            set { Mayo = value; }
        }
        private bool lettuce = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Lettuce
        {
            get { return Lettuce; }
            set { Lettuce = value; }
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
                if (!lettuce) instructions.Add("hold lettuce");
                if (!pickle) instructions.Add("hold pickle");
                if (!tomato) instructions.Add("hold tomato");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}

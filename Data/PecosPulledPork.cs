using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        private bool pickle = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Pickle
        {
            get { return Pickle; }
            set { Pickle = value; }
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
        /// <summary>
        /// The price of the double
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the double
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
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

               
                if (!bun) instructions.Add("hold tortilla strips");
                if (!pickle) instructions.Add("hold pickle");
                
                return instructions;
            }
        }
    }
}

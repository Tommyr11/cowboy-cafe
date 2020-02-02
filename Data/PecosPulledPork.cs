using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        private bool pickle = true;
        /// <summary>
        /// If the sandwich has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        private bool bread = true;
        /// <summary>
        /// If the sandwich has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

               
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                
                return instructions;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        private bool bread = true;
        private bool pickle = true;
        /// <summary>
        /// if the sandwich has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        /// <summary>
        /// if the sandwich has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
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

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");
                

                return instructions;
            }
        }
    }
}

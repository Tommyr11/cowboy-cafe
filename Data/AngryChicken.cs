using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        public bool bread = true;
        public bool pickle = true;
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
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

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");
                

                return instructions;
            }
        }
    }
}

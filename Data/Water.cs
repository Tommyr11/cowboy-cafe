///Author: Thomas Reece
///Project: CowboyCafe
///Class: Water.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// bool for if the drink has a lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        /// <summary>
        /// calories for the drink
        /// </summary>
        public override uint Calories
        {
            get
            {

                return 0;
                
            }
        }
        /// <summary>
        /// price for the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }
        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();



                if (lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
    }
}

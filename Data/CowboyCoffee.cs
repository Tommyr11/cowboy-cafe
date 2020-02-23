///Author: Thomas Reece
///Project: CowboyCafe
///Class: CowboyCoffee.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// To string for Cowboy Coffee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (decaf)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Cowboy Coffee";
                    case Size.Small:
                        return "Small Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
           
        }
        /// <summary>
        /// Bool cream shows if there is cream in the coffe or not
        /// </summary>
        private bool cream = true;
        
        public bool RoomForCream
        {
            get { return cream; }
            set { cream = value; }
        }
        /// <summary>
        /// Bool cream shows if there is ice in the coffe or not
        /// </summary>
        private bool ice = false;

        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Bool cream shows if there is cream in the coffe or not
        /// </summary>
        private bool decaf = true;

        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// Calories in the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Price of the coffee depending on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return .60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();


                if (RoomForCream) instructions.Add("Room for Cream");

                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }
        }
    }
}

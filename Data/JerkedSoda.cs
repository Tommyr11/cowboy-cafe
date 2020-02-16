///Author: Thomas Reece
///Project: CowboyCafe
///Class: JerkedSoda.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Flavor of Jerked Soda
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// Calories in Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            { 
                    switch (Size)
                    {
                        case Size.Large:
                            return 198;
                        case Size.Medium:
                            return 146;
                        case Size.Small:
                            return 110;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                
            }
        }
        /// <summary>
        /// Price of the Jerked Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Special Instructions for soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();



                
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
    }
}

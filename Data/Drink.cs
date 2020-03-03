///Author: Thomas Reece
///Project: CowboyCafe
///Class: Drink.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the price of the Drink
        /// </summary>
        public abstract double Price { get; }

        public bool ice = true;
        public bool Ice { get { return ice; } set { ice = value; } }

        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the calories of the Drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// SpecialInstructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

///Author: Thomas Reece
///Project: CowboyCafe
///Class: Entree.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Entree: IOrderItem
    {
        
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// List of special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

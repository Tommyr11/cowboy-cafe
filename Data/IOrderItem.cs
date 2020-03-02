using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Special instructions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// Price of the item
        /// </summary>
        double Price { get; }
       
    }
}

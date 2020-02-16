///Author: Thomas Reece
///Project: CowboyCafe
///Class: PanDeCampo.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PandeCampo : Side
    {
        /// <summary>
        /// Calories for Pan De Campo
        /// </summary>
        public override uint Calories 
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Price for Pan De Campo
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
    }
}

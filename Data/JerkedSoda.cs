///Author: Thomas Reece
///Project: CowboyCafe
///Class: JerkedSoda.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Override ToString() for jerked soda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            switch (flavor)
            {
                case SodaFlavor.BirchBeer:
                    switch (Size)
                    {
                        case Size.Large:
                            return "Large Birch Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Birch Beer Jerked Soda";
                        case Size.Small:
                            return "Small Birch Beer Jerked Soda";
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                case SodaFlavor.CreamSoda:
                    switch (Size)
                    {
                        case Size.Large:
                            return "Large Cream Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Cream Soda Jerked Soda";
                        case Size.Small:
                            return "Small Cream Soda Jerked Soda";
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                case SodaFlavor.OrangeSoda:
                    switch (Size)
                    {
                        case Size.Large:
                            return "Large Orange Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Orange Soda Jerked Soda";
                        case Size.Small:
                            return "Small Orange Soda Jerked Soda";
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                case SodaFlavor.RootBeer:
                    switch (Size)
                    {
                        case Size.Large:
                            return "Large Root Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Root Beer Jerked Soda";
                        case Size.Small:
                            return "Small Root Beer Jerked Soda";
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                case SodaFlavor.Sarsparilla:
                    switch (Size)
                    {
                        case Size.Large:
                            return "Large Sarsparilla Jerked Soda";
                        case Size.Medium:
                            return "Medium Sarsparilla Jerked Soda";
                        case Size.Small:
                            return "Small Sarsparilla Jerked Soda";
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                default:
                    return "Unrecognizable Item";
            }
                

        }
        /// <summary>
        /// Size of the soda
        /// </summary>
        private Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                ToString();

            }
        }
        /// <summary>
        /// Flavor of Jerked Soda
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                ToString();
            }
        }
        /// <summary>
        /// Ice in the soda
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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

﻿///Author: Thomas Reece
///Project: CowboyCafe
///Class: TexasTea.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// To string for Texas Tea
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (sweet)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            
        }
        private Size size = Size.Small;
        /// <summary>
        /// The Size of the Side
        /// </summary>
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
        /// bool for if tea is sweet
        /// </summary>
        private bool sweet = true;
        public bool Sweet {
            get { return sweet; }
            set { sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                ToString();
            } 
        }
        /// <summary>
        /// bool for if drink has lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// bool for if drink has ice
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
        /// Calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
            }
        }
        /// <summary>
        /// Price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Special instructions for the tea
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

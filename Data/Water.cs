///Author: Thomas Reece
///Project: CowboyCafe
///Class: Water.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Water : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// To string for Water
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Small:
                    return "Small Water";
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }
        private bool ice = true;
        public override bool Ice { get { return ice; } set { ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } }
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
        /// bool for if the drink has a lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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

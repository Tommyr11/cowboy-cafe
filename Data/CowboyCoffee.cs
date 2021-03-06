﻿///Author: Thomas Reece
///Project: CowboyCafe
///Class: CowboyCoffee.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        /// Bool cream shows if there is cream in the coffe or not
        /// </summary>
        private bool cream = false;
        
        public bool RoomForCream
        {
            get { return cream; }
            set { cream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Bool cream shows if there is ice in the coffe or not
        /// </summary>
        private bool ice = false;

        public override bool Ice
        {
            get { return ice; }
            set { ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Bool cream shows if there is cream in the coffe or not
        /// </summary>
        private bool decaf = false;

        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                ToString();
            }
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

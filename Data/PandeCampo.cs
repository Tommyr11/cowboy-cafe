﻿///Author: Thomas Reece
///Project: CowboyCafe
///Class: PanDeCampo.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// To string for Chili Cheese Fries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Small:
                    return "Small Pan de Campo";
                default:
                    throw new NotImplementedException("Unknown size");
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

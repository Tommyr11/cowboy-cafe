///Author: Thomas Reece
///Project: CowboyCafe
///Class: CornDodgers.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side, INotifyPropertyChanged
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
                    return "Large Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Small:
                    return "Small Corn Dodgers";
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
        /// Calories property field for CornDodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// Price property for CornDodgers
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

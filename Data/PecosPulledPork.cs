///Author: Thomas Reece
///Project: CowboyCafe
///Class: PecosPulledPork.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// To string for Chili Cheese Fries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
        private bool pickle = true;
        /// <summary>
        /// If the sandwich has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }
        private bool bread = true;
        /// <summary>
        /// If the sandwich has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

               
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                
                return instructions;
            }
        }
    }
}

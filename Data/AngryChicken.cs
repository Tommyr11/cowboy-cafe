///Author: Thomas Reece
///Project: CowboyCafe
///Class: AngryChicken.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool bread = true;
        private bool pickle = true;
        /// <summary>
        /// if the sandwich has bread
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
        /// if the sandwich has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the double
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");
                

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}

///Author: Thomas Reece
///Project: CowboyCafe
///Class: DakotaDoubleBurger.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    
    public class DakotaDoubleBurger : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// To string for Dakota Double Burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
        private bool cheese = true;
        /// <summary>
        /// If the burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool pickle = true;
        /// <summary>
        /// If the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool tomato = true;
        /// <summary>
        /// If the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// The price of the double
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the double
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
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

                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!bun) instructions.Add("hold bun");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!pickle) instructions.Add("hold pickle");
                if (!tomato) instructions.Add("hold tomato");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged 
    {
        /// <summary>
        /// Property changed event variable that signals something was changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Private backing for subtotal
        /// </summary>
        public double subtotal = 0;
        /// <summary>
        /// Subtotal for the order
        /// </summary>
        public double Subtotal
        {
            get { return subtotal; }
            set
            {
                subtotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
        /// <summary>
        /// Private backing to keep track of the last order number
        /// </summary>
        static private uint lastordernumber = 1;
        /// <summary>
        /// Number for the current order
        /// </summary>
        public uint OrderNumber => lastordernumber++;
        /// <summary>
        /// private backing for items list
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Public list of items
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        /// <summary>
        ///  Adds an item to the item list
        /// </summary>
        /// <param name="i"></param>
        public void Add(IOrderItem i)
        {
            items.Add(i);
            if(i is INotifyPropertyChanged pcItem)
            {
                pcItem.PropertyChanged += OnItemChanged;
            }
            subtotal += i.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
 
        }
        
        /// <summary>
        /// Removes an item from the items list
        /// </summary>
        /// <param name="i"></param>
        public void Remove(IOrderItem i) 
        {
            items.Remove(i);
            if (i is INotifyPropertyChanged pcItem)
            {
                pcItem.PropertyChanged -= OnItemChanged;
            }
            subtotal -= i.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
            InvokePropertyChanged();
        }
        /// <summary>
        /// Author: Zachary Brunner
        /// This method assists in updating the subtotal for changing sizes
        /// </summary>
        /// <param name="i">The item</param>
        /// <param name="new_size">The size the item is suppose to be</param>
        public void subtotalHelperFunction(IOrderItem i, Size new_size)
        {
            Side s;
            Drink d;

            subtotal -= i.Price;
            if (i is Side)
            {
                s = (Side)i;
                s.Size = new_size;
                subtotal += s.Price;
            }
            else
            {
                d = (Drink)i;
                d.Size = new_size;
                subtotal += d.Price;
            }
            InvokePropertyChanged();
        }
        /// <summary>
        /// Author: Zachary Brunner
        /// A helper funtion to invoke the following properties being changed
        /// </summary>
        public void InvokePropertyChanged()
        {
            /* Invoke all events to ensure you don't miss anything */
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            
        }
    }
}

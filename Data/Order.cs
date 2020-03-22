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
        public double Subtotal => subtotal;
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
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}

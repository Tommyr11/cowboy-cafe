using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double subtotal = 0;
        private uint lastordernumber;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items.ToArray();
        public void Add(IOrderItem i)
        {
            items.Add(i);
            subtotal += i.Price;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
        public void Remove(IOrderItem i) 
        {
            items.Remove(i);
            subtotal -= i.Price;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

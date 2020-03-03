using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double subtotal = 0;
        public double Subtotal => subtotal;
        private uint lastordernumber;
        public uint OrderNumber { get; }
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items.ToArray();
        public void Add(IOrderItem i)
        {
            items.Add(i);
            subtotal += i.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
 
        }
        public void Remove(IOrderItem i) 
        {
            items.Remove(i);
            subtotal -= i.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
    }
}

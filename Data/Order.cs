using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double subtotal => 0;
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
        public void Add(IOrderItem i) { }
        public void Remove(IOrderItem i) { }
    }
}

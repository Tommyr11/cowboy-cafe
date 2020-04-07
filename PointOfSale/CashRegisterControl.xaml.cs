using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterModelView.xaml
    /// </summary>
    public partial class CashRegisterModelView : UserControl
    {
        
        public CashRegisterModelView(Order order)
        {
            
            InitializeComponent();
            this.DataContext = order;
            
        }

        private void AcceptOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}

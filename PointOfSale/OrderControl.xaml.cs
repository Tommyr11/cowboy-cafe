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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            var order = new Order();
            this.DataContext = order;
            InitializeComponent();
        }
        /// <summary>
        /// For future purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Completes the order and begins a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {

            var screen = new TransactionControl();
            if (DataContext is Order order)
            {
                screen.DataContext = order;
                this.Content = screen;
            }

        }
        /// <summary>
        /// Cancels the order and begins a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();

        }
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}

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
using CashRegister;



namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private CardTerminal card = new CardTerminal();
        private ReceiptPrinter r = new ReceiptPrinter();
        public TransactionControl()
        {
            InitializeComponent();
        }
        

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }

        private void PayWithCredit_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement screen = null;
            if(DataContext is Order order)
            {
                switch (card.ProcessTransaction(order.subtotalwTax))
                {
                    case ResultCode.InsufficentFunds:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.ReadError:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.UnknownErrror:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.CancelledCard:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.Success:
                        r.Print(order.Receipt(true, 0, 0));
                        screen = new OrderControl();
                        this.Content = screen;
                        break;

                }

            }
        }

        private void PayWithCash_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

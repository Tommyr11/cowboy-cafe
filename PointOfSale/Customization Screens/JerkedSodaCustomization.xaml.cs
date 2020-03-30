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
using Size = CowboyCafe.Data.Size;
using SodaFlavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        private Order order;
        public JerkedSodaCustomization(object dc)
        {
            order = (Order)dc;
            InitializeComponent();
            SmallRadioButton.Checked += OnSize_Checked;
            MediumRadioButton.Checked += OnSize_Checked;
            LargeRadioButton.Checked += OnSize_Checked;
            BB.Checked += OnFlavor_Checked;
            RB.Checked += OnFlavor_Checked;
            OS.Checked += OnFlavor_Checked;
            SS.Checked += OnFlavor_Checked;
            CS.Checked += OnFlavor_Checked;
        }
    
        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            Size s2 = Size.Small;
            Size s3;
            if (DataContext is JerkedSoda pan)
            {
                s3 = pan.Size;
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Small":
                            pan.Size = Size.Small;
                            s2 = Size.Small;
                            break;
                        case "Medium":
                            pan.Size = Size.Medium;
                            s2 = Size.Medium;
                            break;
                        case "Large":
                            pan.Size = Size.Large;
                            s2 = Size.Large;
                            break;
                        default:
                            throw new NotImplementedException("Size not Avialable");
                    }
                }
                JerkedSoda b = new JerkedSoda();
                if (s3 == Size.Medium)
                {
                    b.Size = Size.Medium;
                }
                else if (s3 == Size.Large)
                {
                    b.Size = Size.Large;
                }
                order.subtotalHelperFunction(b, s2);
            }
        }
        private void OnFlavor_Checked(object sender, RoutedEventArgs args)
        {
            if (DataContext is JerkedSoda pan)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "BB":
                            pan.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "CS":
                            pan.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "OS":
                            pan.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "SS":
                            pan.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        case "RB":
                            pan.Flavor = SodaFlavor.RootBeer;
                            break;
                        default:
                            throw new NotImplementedException("Flavor not Avialable");
                    }
                }
            }
        }
    }
}

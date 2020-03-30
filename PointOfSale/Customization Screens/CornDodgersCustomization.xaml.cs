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

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        private Order order;
        public CornDodgersCustomization(object dc)
        {
            order = (Order)dc;
            InitializeComponent();
            SmallRadioButton.Checked += OnSize_Checked;
            MediumRadioButton.Checked += OnSize_Checked;
            LargeRadioButton.Checked += OnSize_Checked;
        }

        /// <summary>
        /// Sets the size of the side object based on the user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Event argument.</param>
        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            Size s2 = Size.Small;
            Size s3;
            if (DataContext is CornDodgers chili)
            {
                s3 = chili.Size;
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Small":
                            chili.Size = Size.Small;
                            s2 = Size.Small;
                            break;
                        case "Medium":
                            chili.Size = Size.Medium;
                            s2 = Size.Medium;
                            break;
                        case "Large":
                            chili.Size = Size.Large;
                            s2 = Size.Large;
                            break;
                        default:
                            throw new NotImplementedException("Size not Avialable");
                    }
                }
                CornDodgers b = new CornDodgers();
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
    }
}

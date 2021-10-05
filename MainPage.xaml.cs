using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Product_Purchase_Management
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<string> suppliers = new List<string>
            {
                "Microsoft","Sony"
            };
            this.supplier.ItemsSource = suppliers;
            this.CSupplier.ItemsSource = suppliers;
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void productName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CProductCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

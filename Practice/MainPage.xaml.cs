using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Practice.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<ImagePrd> Images;

        private ObservableCollection<ProductFashion> Products;

        public MainPage()
        {
            this.InitializeComponent();

            Images = new List<ImagePrd>();
            Images.Add(new ImagePrd { ImagePath = "Assets/1.jpg" });
            Images.Add(new ImagePrd { ImagePath = "Assets/2.jpg" });
            Images.Add(new ImagePrd { ImagePath = "Assets/3.jpg" });
            Images.Add(new ImagePrd { ImagePath = "Assets/4.jpg" });
            Images.Add(new ImagePrd { ImagePath = "Assets/5.jpg" });
            Images.Add(new ImagePrd { ImagePath = "Assets/6.jpg" });

            
            Products= new ObservableCollection<ProductFashion>();

        }

        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((ImagePrd)ImageComboBox.SelectedValue).ImagePath;
            Products.Add(new ProductFashion { ProductName = ProductTextBox.Text, Description = DescriptionTextBox.Text, Image = avatar });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}

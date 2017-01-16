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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Controls3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void StretchModeButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (Image1 != null)
            {
                switch (button.Name)
                {
                    case "FillButton":
                        Image1.Stretch = Windows.UI.Xaml.Media.Stretch.Fill;
                        break;
                    case "NoneButton":
                        Image1.Stretch = Windows.UI.Xaml.Media.Stretch.None;
                        break;
                    case "UniformButton":
                        Image1.Stretch = Windows.UI.Xaml.Media.Stretch.Uniform;
                        break;
                    case "UniformToFillButton":
                        Image1.Stretch = Windows.UI.Xaml.Media.Stretch.UniformToFill;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

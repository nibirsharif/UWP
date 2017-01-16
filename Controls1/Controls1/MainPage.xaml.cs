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

namespace Controls1
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

        private void HyperlinkButton_1_Click(object sender, RoutedEventArgs e)
        {
            HB_TextBlock.Text = "OK";
        }

        private void RadioButton_1_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton_1.IsChecked == true)
            {
                RB_TextBlock.Text = "Checked";
            }
            else
            {
                RB_TextBlock.Text = "Not checked";
            }
        }

        private void ToggleSwitch_1_Toggled(object sender, RoutedEventArgs e)
        {
            if (ToggleSwitch_1.IsOn == true)
            {
                TS_TextBlock.Text = "This is On";
            }
            else
            {
                TS_TextBlock.Text = "This is Off";
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if (ListBox_1.SelectedValue != null)
            {
                LB_TextBlock.Text = month[ListBox_1.SelectedIndex];
            }
            else
            {
                LB_TextBlock.Text = "Select a item from list.";
            }
        }

        private void Ok_1_Click(object sender, RoutedEventArgs e)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if (ComboBox_1.SelectedValue != null)
            {
                CB_TextBlock.Text = month[ComboBox_1.SelectedIndex];
            }
            else
            {
                CB_TextBlock.Text = "Select a item from list.";
            }
        }

        private void PopupButton_Click(object sender, RoutedEventArgs e)
        {
            if (!popup.IsOpen)
            {
                popup.Child = new PopupPanel();
                popup.VerticalOffset = 200.0;
                popup.HorizontalOffset = 60.0;
                popup.IsOpen = true;
            }
        }

        Popup popup = new Popup();
    }
}

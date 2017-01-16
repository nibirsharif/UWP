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

namespace Controls2
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

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (lastNameTextBox.Text != string.Empty)
            {
                if (firstNameTextBox.Text != string.Empty)
                {
                    welcomeTextBlock.Text = "Hello,";
                    nameTextBlock.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                }
                else
                {
                    welcomeTextBlock.Text = "Hello,";
                    nameTextBlock.Text = lastNameTextBox.Text;
                }
            }
            else
            {
                welcomeTextBlock.Text = "Sorry,";
                nameTextBlock.Text = "Last name can't be empty!";
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //dateTextBlock.Text = datePicker.Date.Day + " /" + datePicker.Date.Month + " /" + datePicker.Date.Year;
            dateTextBlock.Text = datePicker.Date.ToString("D");
            //timeTextBlock.Text = timePicker.Time.Hours + ":" + timePicker.Time.Minutes;
            //timePicker.ClockIdentifier = Windows.Globalization.ClockIdentifiers.TwelveHour;
            timeTextBlock.Text = timePicker.Time.ToString("T");
        }
    }
}

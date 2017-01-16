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

namespace LocalStorage
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

    protected override async void OnNavigatedTo(NavigationEventArgs e)
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

        if ((string)localSettings.Values["IsFirstTimeLaunched"] == "true")
        {
            textBlock.Text = localSettings.Values["date"].ToString();
        }
        else
        {
            DateTime start = DateTime.Now;

            localSettings.Values["IsFirstTimeLaunched"] = "true";
            localSettings.Values["date"] = start.Date.ToString();

        }

        DateTime start1 = DateTime.Parse(localSettings.Values["date"].ToString());
        DateTime end = DateTime.Now;
        int trialPeriod = 7;

        if ((end.Date - start1.Date).Days <= trialPeriod)
        {
            textBlock1.Text = "You have " + (trialPeriod - (end.Date - start1.Date).Days).ToString() + " left";
        }
    }
    }
}

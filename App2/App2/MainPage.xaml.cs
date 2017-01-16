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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
public ObservableCollection<Images> Items { get; private set; } = new ObservableCollection<Images>();
        public MainPage()
        {
            this.InitializeComponent();

            //BitmapImage images1 = new BitmapImage(new Uri("ms-appx:///Images/milkyway1.jpg", UriKind.RelativeOrAbsolute));
            //string title1 = "Milkyway 1";

            //BitmapImage images2 = new BitmapImage(new Uri("ms-appx:///Images/milkyway2.jpg", UriKind.RelativeOrAbsolute));
            //string title2 = "Milkyway 2";

            //BitmapImage images3 = new BitmapImage(new Uri("ms-appx:///Images/milkyway3.jpg", UriKind.RelativeOrAbsolute));
            //string title3 = "Milkyway 3";

            //BitmapImage images4 = new BitmapImage(new Uri("ms-appx:///Images/milkyway4.jpg", UriKind.RelativeOrAbsolute));
            //string title4 = "Milkyway 4";

            //BitmapImage images5 = new BitmapImage(new Uri("ms-appx:///Images/milkyway5.jpg", UriKind.RelativeOrAbsolute));
            //string title5 = "Milkyway 5";

            //BitmapImage images6 = new BitmapImage(new Uri("ms-appx:///Images/milkyway6.jpg", UriKind.RelativeOrAbsolute));
            //string title6 = "Milkyway 6";

            //BitmapImage images7 = new BitmapImage(new Uri("ms-appx:///Images/milkyway7.jpg", UriKind.RelativeOrAbsolute));
            //string title7 = "Milkyway 7";

            //BitmapImage images8 = new BitmapImage(new Uri("ms-appx:///Images/milkyway8.jpg", UriKind.RelativeOrAbsolute));
            //string title8 = "Milkyway 8";

            //BitmapImage images9 = new BitmapImage(new Uri("ms-appx:///Images/milkyway9.jpg", UriKind.RelativeOrAbsolute));
            //string title9 = "Milkyway 9";

            //this.Items.Add(new Images { images = images1, title = title1 });
            //this.Items.Add(new Images { images = images2, title = title2 });
            //this.Items.Add(new Images { images = images3, title = title3 });
            //this.Items.Add(new Images { images = images4, title = title4 });
            //this.Items.Add(new Images { images = images5, title = title5 });
            //this.Items.Add(new Images { images = images6, title = title6 });
            //this.Items.Add(new Images { images = images7, title = title7 });
            //this.Items.Add(new Images { images = images7, title = title8 });
            //this.Items.Add(new Images { images = images8, title = title9 });


BitmapImage[] bitmapImage = new BitmapImage[9];
bitmapImage[0] = new BitmapImage(new Uri("ms-appx:///Images/milkyway1.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[1] = new BitmapImage(new Uri("ms-appx:///Images/milkyway2.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[2] = new BitmapImage(new Uri("ms-appx:///Images/milkyway3.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[3] = new BitmapImage(new Uri("ms-appx:///Images/milkyway4.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[4] = new BitmapImage(new Uri("ms-appx:///Images/milkyway5.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[5] = new BitmapImage(new Uri("ms-appx:///Images/milkyway6.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[6] = new BitmapImage(new Uri("ms-appx:///Images/milkyway7.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[7] = new BitmapImage(new Uri("ms-appx:///Images/milkyway8.jpg", UriKind.RelativeOrAbsolute));
bitmapImage[8] = new BitmapImage(new Uri("ms-appx:///Images/milkyway9.jpg", UriKind.RelativeOrAbsolute));

string[] title = new string[] { "Milkyway 1", "Milkyway 2", "Milkyway 3", "Milkyway 4", "Milkyway 5", "Milkyway 6", "Milkyway 7", "Milkyway 8", "Milkyway 9" };

for (int i = 0; i < 9; i++)
{
    this.Items.Add(new Images { images = bitmapImage[i], title = title[i] });
}

MyFlipView.ItemsSource = Items;
        }
    }


public class Images
{
    public BitmapImage images { get; set; }
    public string title { get; set; }
}
}

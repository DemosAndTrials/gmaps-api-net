using System;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using WinStoreApp.Map;

namespace WinStoreApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var img = Test2();
            Image.Source = new BitmapImage(img);
        }

        /// <summary>
        /// https://developers.google.com/maps/faq?utm_source=welovemapsdevelopers&utm_campaign=mdr-launch#languagesupport
        /// </summary>
        private Uri Test2()
        {
            var map = new StaticMapRequest();
            map.Center = new Location("48 Boulevard Jourdan, Paris, France, 75014");
            map.Size = new Size(400, 400);
            map.Zoom = 14;
            map.Sensor = false;
            map.Markers = new MapMarkersCollection();


            var mapMarkers = new MapMarkers();
            mapMarkers.Color = Colors.Chartreuse;
            mapMarkers.Locations = new List<Location>();
            var location = new Location("48 Boulevard Jourdan, Paris, France, 75014");
            mapMarkers.Locations.Add(location);

            map.Markers.Add(mapMarkers);

            map.Language = "fr";

            var imgTagSrc = map.ToUri();

            return imgTagSrc;
        }
    }
}

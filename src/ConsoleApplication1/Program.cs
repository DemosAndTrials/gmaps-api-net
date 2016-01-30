using System.Collections.Generic;
using System.Drawing;
using Google.Maps;
using Google.Maps.StaticMaps;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        /// <summary>
        /// https://developers.google.com/maps/faq?utm_source=welovemapsdevelopers&utm_campaign=mdr-launch#languagesupport
        /// </summary>
        private static void Test2()
        {
            var map = new StaticMapRequest();
            map.Center = new Location("48 Boulevard Jourdan, Paris, France, 75014");
            map.Size = new System.Drawing.Size(400, 400);
            map.Zoom = 14;
            map.Sensor = false;
            map.Markers = new MapMarkersCollection();


            var mapMarkers = new MapMarkers();
            mapMarkers.Locations = new List<Location>();
            var location = new Location("48 Boulevard Jourdan, Paris, France, 75014");
            mapMarkers.Locations.Add(location);
            mapMarkers.Color = Color.Blue;

            map.Markers.Add(mapMarkers);

            map.Language = "fr";

            var imgTagSrc = map.ToUri();
        }
    }
}

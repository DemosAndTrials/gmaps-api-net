using System.Collections.Generic;

namespace WinStoreApp.Map
{
    /// <summary>
    /// Contains a collection of <see cref="MapMarkers" />.
    /// </summary>
    public class MapMarkersCollection : List<MapMarkers>
    {
        public void Add(Location value)
        {
            MapMarkers m = new MapMarkers();
            m.Locations.Add(value);
            base.Add(m);
        }
    }
}

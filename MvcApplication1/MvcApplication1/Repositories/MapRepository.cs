using MvcApplication1.Models;

namespace MvcApplication1.Repositories
{
    public class MapRepository
    {
        public Map GetById(int id)
        {
            return new Map
                   {
                       
                       Name = "Joe's House",
                       Zoom = 10,
                       LatLng = new LatLng { Latitude = 10.471389, Longitude = -66.960556, },
                       Locations =
                           {
                               new Location
                               {
                                   Name = "St. Julians, Sevenoaks, UK",
                                   LatLng = new LatLng { Latitude = 51.25136, Longitude = 0.21992 },
                                   Image = "st_julians.jpg"
                               },
                               new Location
                               {
                                   Name = "Kadasali, Gujerat, India",
                                   LatLng = new LatLng { Latitude = 21.235142, Longitude = 71.4462 },
                                   Image = "india.jpg"
                               },
                               new Location
                               {
                                   Name = "Esdelle Street, Norwich, UK",
                                   LatLng = new LatLng { Latitude = 52.638291, Longitude = 1.293747 },
                                   Image = "norwich.jpg"
                               },
                               new Location
                               {
                                   Name = "Belsize Park, London, UK",
                                   LatLng = new LatLng { Latitude = 51.551479, Longitude = -0.165321 },
                                   Image = "belsize_park.jpg"
                               },
                               new Location
                               {
                                   Name = "University of East Anglia, Norwich, UK",
                                   LatLng = new LatLng { Latitude = 52.62007, Longitude = 1.237147 },
                                   Image = "uea.jpg"
                               },
                               new Location
                               {
                                   Name = "Sendai, Japan",
                                   LatLng = new LatLng { Latitude = 38.296441, Longitude = 140.831809 },
                                   Image = "sendai.jpg"
                               },
                               new Location
                               {
                                   Name = "Brunswick Square, Brighton, UK",
                                   LatLng = new LatLng { Latitude = 50.824342, Longitude = -0.158647 },
                                   Image = "brunswick.jpg"
                               },
                               new Location
                               {
                                   Name = "Sydney, Australia",
                                   LatLng = new LatLng { Latitude = -33.881749, Longitude = 151.215485 },
                                   Image = "sydney.jpg"
                               },
                               new Location
                               {
                                   Name = "Caracas - Montalban, Venezuela",
                                   LatLng = new LatLng { Latitude = 10.471389, Longitude = -66.960556 },
                                   Image = "uea.jpg"
                               }
                            
                           }
                   };
        }
    }
}
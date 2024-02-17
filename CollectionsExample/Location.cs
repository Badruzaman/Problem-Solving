using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Location
    {
        double lat, lan;
        public Location(double lat, double lan)
        {
            this.lat = lat;
            this.lan = lan;
        }

        public double Latitude
        {
            get { return lat; }
        }
        public double Longitude
        {
            get { return lan; }
        }
    }
}

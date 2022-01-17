using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApplication
{
    public class MapPosition
    { 
    public double Latitude { get; set; }
        public double Longitude { get; set; }
    
        public MapPosition(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
    }
}


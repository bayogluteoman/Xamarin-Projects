using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApplication
{
    public class MapModel
    {
        public Double latitude { get; set; }
        public Double longtitude { get; set; }

        public MapModel(Double latitude, Double longtitude)
        {
            this.latitude = latitude;
            this.longtitude = longtitude;
        }
    }
}

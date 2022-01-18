using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApplication
{
    public class CarouselModel
    {
        public String url { get; set; }
        public String text { get; set; }

        public CarouselModel(String url, String text)
        {
            this.url = url;
            this.text = text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApplication
{
    public class Medicine
    {
        public String MedicineName { get; set; }
        public String Description { get; set; }
        public String StockNumber { get; set; }

        public String Image { get; set; }

        public Medicine(String MedicineName, String Description, String Image, String StockNumber)
        {
            this.MedicineName = MedicineName;
            this.Description = Description;
            this.Image = Image;
            this.StockNumber = StockNumber;
        }
        public Medicine()
        {
          
        }
    }
}

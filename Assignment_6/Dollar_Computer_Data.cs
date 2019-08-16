using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Dollar_Computer_Data
    {
       public enum Dollar_Computer_fields
        {
            Productid,
            Condition,
            Cost,
            Platform,
            Os,
            Model,
            Manufacturer,
            Memory,
            Lcdsize,
            Hdd,
            Gputype,
            Cpunumber,
            Cpubrand,
            Cputype,
            Cpuspeed,
            Webcam,
            Num_of_fields

        }

        public string Product_Id { get; set; }
        public string Condition { get; set; }
        public string Cost { get; set; }
        public string Platform { get; set; }
        public string OS { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Memory { get; set; }
        public string LCD_Size { get; set; }
        public string Hdd { get; set; }
        public string GPU_Type { get; set; }
        public string CPU_number { get; set; }
        public string CPU_Brand { get; set; }
        public string CPU_Type { get; set; }
        public string CPU_speed { get; set; }
        public string web_cam { get; set; }


        

    }
}

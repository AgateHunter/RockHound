using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHound
{
    internal class WeatherData
    {
        //create the coordinates class (includes longitude and latitude)
        
        public class coord
        {
            double lon { get; set; }
            double lat { get; set; }
        }

        //create the weather class - identifies the broad overview of weather

        public class weather
        {
            public int id { get; set; }

             public string main { get; set; }

           public string description { get; set; }
          public string icon { get; set; }
 
        }

        //create the main class - this gives detail of temperature, pressure, humidity, overall feel, min/max temp for the day, sea level, etc...
        public class main
        {
            public double temp { get; set; }

           
            public double feel { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }   
            public double pressure { get; set; }
            public double sea_level { get; set; }
            public double ground_level { get; set; }
            public double humidity { get; set; }
            public double temp_kf { get; set; }

               

        }
        //create class for wind - speed, degrees, gust
        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }

        }

        //create class for clouds

        public class clouds
        {
            public double all { get; set; }
        }

        //create a class for System data
        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }

        }

        //create a root class for additional data

        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }

            public sys sys { get; set; }
            
        }

    }
}

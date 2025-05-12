using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tools
{
    public static class APIClass
    {
        public static string temper;

        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.open-meteo.com/v1/forecast?latitude=54.3282&longitude=48.3866&hourly=temperature_2m");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            response.Close();

            dynamic str = JsonConvert.DeserializeObject(json);
            temper = str.hourly.temperature_2m[20].ToString();
        }
    }
}

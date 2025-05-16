using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tools
{
    public static class APIClass
    {
        public static string temper;
        public static Dictionary<string, double> vals = new Dictionary<string, double>();

        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.open-meteo.com/v1/forecast?latitude=54.19&longitude=48.22&hourly=temperature_2m");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            response.Close();

            dynamic str = JsonConvert.DeserializeObject(json);
            temper = str.hourly.temperature_2m[20].ToString();
        }

        public static void Vals ()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            response.Close();

            dynamic str = JsonConvert.DeserializeObject(json);
            string usd = str.Valute.USD.Value.ToString();
            string eur = str.Valute.EUR.Value.ToString();
            string cny = str.Valute.CNY.Value.ToString();

            double Usd = Convert.ToDouble(usd);
            double Eur = Convert.ToDouble(eur);
            double Cny = Convert.ToDouble(cny);

            vals.Add("RUB", 1);
            vals.Add("USD", Math.Round(Usd, 2));
            vals.Add("EUR", Math.Round(Eur, 2));
            vals.Add("CNY", Math.Round(Cny, 2));
        }
    }
}

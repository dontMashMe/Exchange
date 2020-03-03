using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {

            ////IDictionary<string, JToken> dic = new Dictionary<string, JToken>();
            ////var o = JObject.Parse(json);

            ////foreach(JToken child in o.Children())
            ////{
            ////    if (child is JProperty property)
            ////    {
            ////        dic.Add(property.Name, property.Value);
            ////        //Console.WriteLine(property.Name + ":" + property.Value);
            ////    }
            ////}

            ////foreach(KeyValuePair<string, JToken> a in dic)
            ////{
            ////    Console.WriteLine(a.Key + ":" + a.Value);
            ////}
            ////CurrencyRepository rep = new CurrencyRepository();
            ////List<Currency> currencies = rep.GetCurrencies();
            ////foreach(Currency a in currencies)
            ////{
            ////    Console.WriteLine("id:{0}", a.CurrencyID);
            ////    Console.WriteLine("isoCode: {0}", a.IsoCode);
            ////    Console.WriteLine("name: {0}", a.Name);
            ////    Console.WriteLine("\n");
            ////}

            //foreach(KeyValuePair<string, double> a in dic)
            //{
            //    Console.WriteLine(a.Key + ":" + a.Value);
            //}
            //rep.UpdateDataBase(rep.GetCurrenciesAPI());



            //List<Currency> apiCurrencies = rep.GetCurrenciesAPI();
            //List<Currency> dataBaseCurrencies = rep.PullFromDataBase();
            //Console.WriteLine("**-----API------**");
            //foreach(Currency a in apiCurrencies)
            //{
            //    Console.WriteLine(a.Name);
            //}
            //Console.WriteLine("**----DATABASE----**");
            //foreach(Currency a in dataBaseCurrencies)
            //{
            //    Console.WriteLine(a.Name);
            //}
            //Console.WriteLine("**---DIFFERENCES---**");
            //foreach(Currency a in differences)
            //{
            //    Console.WriteLine(a.Name);
            //}


            //Console.WriteLine(rep.RetrieveRates("AED"));
            //IDictionary<string, double> dic = rep.GetRatesAPI();
            //List<Currency> currencies = new List<Currency>();
            //string url = "http://openexchangerates.org/api/currencies.json";
            //string json = rep.CallRestMethod(url);
            ////string json = "";
            ////StreamReader osr = new StreamReader("iso.json");
            ////using (osr) json = osr.ReadToEnd();
            //var o = JObject.Parse(json);
            //int counter = 0;
            //foreach (JToken child in o.Children())
            //{
            //    counter++;
            //    if (child is JProperty property)
            //    {
            //        currencies.Add(new Currency
            //        {
            //            CurrencyID = counter,
            //            IsoCode = property.Name,
            //            Rate = rep.RetrieveRates(property.Name, dic),
            //            Name = (string)property.Value
            //        });

            //    }
            //}
            //foreach(var a in currencies)
            //{
            //    Console.WriteLine(a.IsoCode + ":" + a.Rate);
            //}

            //Console.WriteLine(rep.Exchange("HRK", "EUR", 350));

            //YY-MM-DD


            //foreach(var day in last7days)
            //{
            //    string url = "https://openexchangerates.org/api/historical/" + $"{day:yyyy-MM-dd}" + ".json?app_id=3eadbd44c2f04c33aa75ac6664e83c50";
            //    Console.WriteLine(url);
            //}

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //List<int>

            CurrencyRepository rep = new CurrencyRepository();
            //var filterCurrencies = rep.Filter("","croat");
            //foreach(var a in filterCurrencies)
            //{
            //    Console.WriteLine(a.Name);
            //}
            //Console.WriteLine(filterCurrencies.Count());

            //var currencies = rep.PullFromDataBase(); 
            //foreach(var a in currencies)
            //{
            //    Console.WriteLine(a.IsoCode + ":" + CountryName(a.IsoCode));
            //}

            //var currencies = rep.GetHistoricalRatesAPI("HRK");
            //foreach(var a in currencies)
            //{
            //    Console.WriteLine(a);
            //}
            ///var original = double.Parse(Console.ReadLine());
            //var newV= double.Parse(Console.ReadLine());
            //Console.WriteLine((newV - original) / Math.Abs(original) * 100 +"%");
            var toDate = DateTime.Now;
            var fromDate = DateTime.Now.AddDays(-14);
            var dates = DateRange(fromDate, toDate);
            foreach (var day in dates)
            {
                Console.WriteLine($"{day:dd-yyyy-MM}");
            }
            //var list = HistoricalRatesRange("EUR", fromDate);
            //foreach (var a in list)
            //{
            //    Console.WriteLine(a);
            //}
        }
        
        public static IEnumerable<DateTime> DateRange(DateTime fromDate, DateTime toDate)
        {
            return Enumerable.Range(0, toDate.Subtract(fromDate).Days + 1)
                             .Select(d => fromDate.AddDays(d));
        }
       /*
        public static List<double> HistoricalRatesRange(string isocode, DateTime fromDate)
        {
            string key = "dfb50a20a7bc4aa88612b295136b2fe1";
            var toDate = DateTime.Now;
            var dates = DateRange(fromDate, toDate);
            List<double> rates = new List<double>();
            CurrencyRepository rep = new CurrencyRepository();
            foreach (var day in dates)
            {
                IDictionary<string, double> dic = new Dictionary<string, double>();
                string url = "https://openexchangerates.org/api/historical/" + $"{day:yyyy-MM-dd}" + ".json?app_id=" + key;
                string json = rep.CallRestMethod(url);
                var o = JObject.Parse(json);
                foreach (JToken child in o.Children())
                {
                    foreach (JToken grandChild in child)
                    {
                        foreach (JToken grandGrandChild in grandChild)
                        {
                            var property = grandGrandChild as JProperty;
                            if (property != null)
                            {
                                dic.Add(property.Name, Convert.ToDouble(property.Value));
                            }
                        }
                    }
                }
                foreach (KeyValuePair<string, double> a in dic)
                {
                    if (a.Key == isocode) rates.Add(Math.Round(a.Value, 2));
                }
            }
            return rates;
        }
        //https://openexchangerates.org/api/historical/2012-07-10.json?app_id=YOUR_APP_ID
        //3eadbd44c2f04c33aa75ac6664e83c50
        
        public static string CountryName(string iso)
        {
            if (iso == "EUR") return "Euro";
            CurrencyRepository rep = new CurrencyRepository();
            StreamReader oSr = new StreamReader("curr.json");
            string json = " ";
            using (oSr)
            {
                json = oSr.ReadToEnd();
            }
            JObject jObject = JObject.Parse(json);
            var countries = jObject["country"].ToList();
            var currencies = rep.PullFromDataBase();
            foreach (JObject a in countries)
            {
                foreach (var b in currencies)
                {
                    var currCode = a.GetValue("currencyCode");
                    string counName = a.GetValue("countryName").ToString();
                    if (currCode.ToString() == iso) return counName;

                }

            }
            return string.Empty;

        }
        */


    }

   
}

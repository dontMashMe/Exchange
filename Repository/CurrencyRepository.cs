using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Repository
{
    public class CurrencyRepository
    {

        //-------------API REQUESTS--------------------
        readonly string key = "fe4af4b086324a9fb96ee19cca7dba11";
        public string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
           enc);
            string result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public IDictionary<string, double> GetRatesAPI()
        {
            CurrencyRepository rep = new CurrencyRepository();
            string url = "https://openexchangerates.org/api/latest.json?app_id=" + key;
            string json = rep.CallRestMethod(url);
            IDictionary<string, double> dic = new Dictionary<string, double>();
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
            return dic;
        }

        public List<Currency> GetCurrenciesAPI()
        {         
            CurrencyRepository rep = new CurrencyRepository();
            IDictionary<string, double> dic = rep.GetRatesAPI();
            List<Currency> currencies = new List<Currency>();
            string url = "http://openexchangerates.org/api/currencies.json";
            string json = CallRestMethod(url);
            var o = JObject.Parse(json);
            int counter = 0;
            foreach (JToken child in o.Children())
            {
                counter++;             
                if (child is JProperty property)
                {
                    currencies.Add(new Currency { 
                        CurrencyID = counter, 
                        IsoCode = property.Name,
                        Rate = (decimal)rep.RetrieveRates(property.Name, dic),
                        Name = (string)property.Value,
                        Country = rep.CountryName(property.Name)                     
                    });
                    
                }
            }
            return currencies;     
        }
        public IEnumerable<DateTime> DateRange(DateTime fromDate, DateTime toDate)
        {
            return Enumerable.Range(0, toDate.Subtract(fromDate).Days + 1)
                             .Select(d => fromDate.AddDays(d));
        }
        public List<double> GetHistoricalRatesAPI(string isocode, DateTime fromDate)
        {
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


        //-------------DATABASE--------------------
        readonly string connectionString = @"Server=193.198.57.189; DATABASE=DOTNET2019;User ID=student;Password=stu!2019neT;Integrated Security=False;Trusted_Connection=False;";
        public void UpdateDataBase(List<Currency> currencies)
        {
            CurrencyRepository rep = new CurrencyRepository();
            IDictionary<string, double> dic = rep.GetRatesAPI();
            DeleteDataBase();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                foreach (Currency a in currencies)
                {   
                    command.CommandText = "INSERT INTO [bebek_Currencies] (CURRENCY_ID, ISO_CODE, NAME, RATE, COUNTRY) VALUES ('" + a.CurrencyID + "', '"+ a.IsoCode + "', '"+ RemoveSpecialCharacters(a.Name) + "', '"+rep.RetrieveRates(a.IsoCode,dic)+"', '"+rep.CountryName(a.IsoCode)+"')";
                    using(DbDataReader oReader = command.ExecuteReader())
                    {

                    }
                }


            }
        }

        public void DeleteDataBase()
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "DELETE FROM [bebek_Currencies]";
                using (DbDataReader oReader = command.ExecuteReader())
                {

                }
            }

        }
        public  List<Currency> PullFromDataBase()
        {
            List<Currency> currencies = new List<Currency>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "SELECT * FROM [bebek_Currencies]";
                using(DbDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        try
                        {
                            currencies.Add(new Currency
                            {
                                CurrencyID = (int)reader["CURRENCY_ID"],
                                IsoCode = (string)reader["ISO_CODE"],
                                Rate = (decimal)reader["RATE"],
                                Name = (string)reader["NAME"],
                                Country = (string)reader["COUNTRY"]

                            });
                        }
                        catch
                        {

                        }
                      
                    }
                }
            }

            return currencies;
        }

        public IDictionary<string, double> RatesFromDataBase()
        {
            var currencies = PullFromDataBase();
            IDictionary<string, double> dic = new Dictionary<string, double>();
            foreach (var a in currencies)
            {
                dic.Add(a.IsoCode, (double)a.Rate);
            }
            return dic;
        }

        public void InsertNewCurrency(Currency cur)
        {
            var currencies = PullFromDataBase();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "INSERT INTO [bebek_Currencies] (CURRENCY_ID, ISO_CODE, NAME, RATE, COUNTRY) VALUES ('" + cur.CurrencyID + "', '" + cur.IsoCode + "', '" + RemoveSpecialCharacters(cur.Name) + "', '" + cur.Rate + "', '"+cur.Country+"')";
                using (DbDataReader oReader = command.ExecuteReader())
                {

                }

            }

        }

        public void DeleteCurrency(string iso)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "DELETE FROM [bebek_Currencies] WHERE [ISO_CODE] = '" + iso + "'";
                using (DbDataReader oReader = command.ExecuteReader())
                {

                }
            }
        }

        public void UpdateCurrency(Currency currency)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "UPDATE [bebek_Currencies] SET ISO_CODE ='"+currency.IsoCode+ "', NAME='"+ currency.Name+"', RATE='"+currency.Rate+"', COUNTRY='"+currency.Country+"' WHERE CURRENCY_ID='"+currency.CurrencyID+"'";
                using (DbDataReader oReader = command.ExecuteReader())
                {

                }
            }
        }

        //----------FUNCTIONALITY----------------

        public string CountryName(string iso)
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

        public double RetrieveRates(string isoCode, IDictionary<string, double> dic)
        {
            foreach (KeyValuePair<string, double> a in dic)
            {
                if (a.Key == isoCode) return a.Value;
            }
            return 0.0;
        }
        public double Exchange(string iso1, string iso2, double iznos)
        {
            IDictionary<string, double> dic = RatesFromDataBase();
            double rate1 = 0, rate2 = 0;
            foreach(KeyValuePair<string, double> a in dic)
            {
                if (iso1 == a.Key) rate1 = a.Value;
                else if (iso2 == a.Key) rate2 = a.Value;
            }
            return Math.Round(iznos * (rate2/rate1), 5);
        }       
        public string NameFromIso(string iso)
        {
            var currencies = PullFromDataBase();
            foreach(var a in currencies)
            {
                if (a.IsoCode == iso) return a.Name;
            }
            return string.Empty;
        }
        public static string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }

        public List<Currency> FilterName(string name)
        {
            var currencies = PullFromDataBase();
            var filterCurr = new List<Currency>();
            filterCurr = currencies.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return filterCurr;
        }
        
        public List<Currency> Filter(string iso, string country)
        {
            var currencies = PullFromDataBase();
            var filterCurrency = new List<Currency>();
            filterCurrency = currencies.Where(x=>x.IsoCode.ToLower().Contains(iso.ToLower()) && x.Country.ToLower().Contains(country.ToLower())).ToList();
            if (country == string.Empty && iso == string.Empty) return currencies;
            return filterCurrency;

        }
        public List<Currency> FilterCRUD(string search)
        {
            var currencies = PullFromDataBase();
            var filtered = new List<Currency>();
            filtered = currencies.Where(x => x.Country.ToLower().Contains(search.ToLower()) || x.IsoCode.ToLower().Contains(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower())).ToList();
            return filtered;
            
        }
        public double Change(List<double> rates)
        {
            return (rates.Last() - rates.First()) / Math.Abs(rates.First()) * 100;         
        }

    }
}

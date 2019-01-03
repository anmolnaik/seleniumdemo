using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoApplication.Src.Model
{
    public class DataContainer
    {
        static string filepath = @"C:\Users\1862\Documents\Visual Studio 2015\Projects\SeleniumDemoApplication\SeleniumDemoApplication\Src\Json\LoginData.json";        

        static string GetJsonData() => File.ReadAllText(filepath);        

        static Dictionary<string, JsonSettings> jsonRead;        

        static string json2;

        private static Dictionary<string, JsonSettings> jsonData;

        public string uuid = "New" + Guid.NewGuid().ToString();

        public static void DataRead()
        {
            jsonRead = JsonConvert.DeserializeObject<Dictionary<string, JsonSettings>>(GetJsonData()) ?? new Dictionary<string, JsonSettings>();
        }
        //public Dictionary<string, JsonSettings> DataRead2()
        //{
        //    return JsonConvert.DeserializeObject<Dictionary<string, JsonSettings>>(GetJsonData()) ?? new Dictionary<string, JsonSettings>();
        //}
        public static void Data()
        {
            JsonSettings js = new JsonSettings();
            js.Id = new Random().Next(0, 10);
            js.SSN = new Random().Next(1000, 9999);
            js.Message = "Testing";
            js.UUID = Guid.NewGuid().ToString();

            jsonRead.Add(js.UUID, js);

            string json = JsonConvert.SerializeObject(jsonRead, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(filepath, json);
        }
        public static void Data(string message)
        {
            JsonSettings js = new JsonSettings();

            js.Id = new Random().Next(0, 10);
            js.SSN = new Random().Next(1000, 9999);
            js.Message = message;
            js.UUID = Guid.NewGuid().ToString();            

            jsonRead.Add(js.UUID, js);

            string json = JsonConvert.SerializeObject(jsonRead, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(filepath, json);
        }
        public static void SearchProduct(string searchText,string priceRange,string color)
        {
            JsonSettings js2 = new JsonSettings();

            js2.Id = new Random().Next(0, 10);
            js2.SearchText = searchText;
            js2.PriceRange = priceRange;
            js2.Color = color;
            js2.UUID = "New"+Guid.NewGuid().ToString();
            
            if (!IsSearchTextAllreadyPresent(searchText))
                jsonRead.Add(js2.UUID, js2);

            json2 = JsonConvert.SerializeObject(jsonRead, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(filepath, json2);
        }
        public static void UpdateColor(string oldColor, string newColor)
        {
            jsonData = JsonConvert.DeserializeObject<Dictionary<string, JsonSettings>>(GetJsonData()) ?? new Dictionary<string, JsonSettings>();
            foreach (var item in jsonData)
            {
                if (item.Value.Color == oldColor)
                {
                    item.Value.Color = newColor;

                    jsonRead[item.Key] = item.Value;

                    json2 = JsonConvert.SerializeObject(jsonRead, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    File.WriteAllText(filepath, json2);
                    Console.WriteLine("Color is updated.");
                    break;
                }
                else {
                    Console.WriteLine("Color is not updated.");
                }
            }            
        }
        public static bool IsSearchTextAllreadyPresent(string searchText)
        {
            jsonData = JsonConvert.DeserializeObject<Dictionary<string, JsonSettings>>(GetJsonData()) ?? new Dictionary<string, JsonSettings>();
            foreach (var item in jsonData)
            {
                if (item.Value.SearchText == searchText)
                    return true;
            }
            return false;
        }        

        public static void DisplayData()
        {
            jsonRead = JsonConvert.DeserializeObject<Dictionary<string, JsonSettings>>(GetJsonData()) ?? new Dictionary<string, JsonSettings>();
            foreach (var item in jsonRead)
            {
                if (item.Value.UUID.Contains("New"))
                {
                    Console.WriteLine("Product Search based on :");
                    Console.WriteLine(item.Value.SearchText);
                    Console.WriteLine(item.Value.Color);
                    Console.WriteLine(item.Value.PriceRange);
                }
            }            
        }        
    }   
}

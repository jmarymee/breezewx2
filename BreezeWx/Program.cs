using Org.OpenAPITools.Api;
using System.Diagnostics;
using System.Text.Json;

namespace BreezeWx;

class Program
{
    static void Main(string[] args)
    {
        GetAirportData();
        Console.WriteLine("Hello, World!");
    }

    public static void GetAirportData()
    {
        try
        {

            DataApi api = new DataApi("https://aviationweather.gov/");
            //api.DataAirport("KSEA", null, "json");

            var response = api.DataMetarsWithHttpInfo("KSEA", "json");

            //var metar = api.DataMetarsWithHttpInfo("KSEA", "json");

            string metarString = response.RawContent;


            MetarClass[] result = System.Text.Json.JsonSerializer.Deserialize<MetarClass[]>(metarString);



        }
        catch (Exception e)
        {
            Debug.Print("Exception when calling AirportsApi.GetAirport: " + e.Message);
        }
    }
}

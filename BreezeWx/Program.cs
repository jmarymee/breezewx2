using Org.OpenAPITools.Api;
using System.Diagnostics;

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

            var rseponse = api.DataAirportWithHttpInfo("KSEA",null, "json");

            var metar = api.DataMetarsWithHttpInfo("KSEA", "json");


        }
        catch (Exception e)
        {
            Debug.Print("Exception when calling AirportsApi.GetAirport: " + e.Message);
        }
    }
}

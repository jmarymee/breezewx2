using SuperConvert.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeWx
{
    public class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetApiResponseAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        public static async Task<MetarClass> GetMetar(string icao)
        {
            try
            {
                client.BaseAddress = new Uri("https://aviationweather.gov/api/data/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "Breezewx");
                HttpResponseMessage response = await client.GetAsync("metar?ids=" + icao + "&format=json");

                string respBody = await response.Content.ReadAsStringAsync();

                DataTable dt = respBody.ToDataTable("MetarTable");
                DataTable dt2 = respBody.ToDataTable("MetarTable");
                dt.Merge(dt2);

                //dt.ToCsv(".", "metar", ',');


                MetarClass[] result = System.Text.Json.JsonSerializer.Deserialize<MetarClass[]>(respBody);

                return result[0];
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }
    }
}

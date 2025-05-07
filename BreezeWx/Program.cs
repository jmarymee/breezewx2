using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics.Metrics;
using System.Text.Json.Serialization;
using SuperConvert.Extensions;
using System.Data;
using BreezeWx;

namespace Breezewx
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

                dt.ToCsv(".", "metar", ',');


                MetarClass[] result = System.Text.Json.JsonSerializer.Deserialize<MetarClass[]>(respBody);

                return result[0];
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        public static async Task Main(string[] args)
        {


            //MetarClass reps2 = await GetMetar("KSEA");

            IngestWxAPIClass wx = new IngestWxAPIClass();
            DataTable wxDT = wx.GetDataTabletFromCSVFile(@"C:\Users\jd\Downloads\metars.csv");

            var dr = wxDT.Select("station_id = 'KSEA'");

            var metars = from row in wxDT.AsEnumerable()
                         where row.Field<string>("station_id").Equals("KSEA")
                         select new
                         {
                             StationId = row.Field<string>("station_id"),
                             RawText = row.Field<string>("raw_text"),
                             Temp = row.Field<string>("temp_c"),
                             Dewp = row.Field<string>("dewpoint_c"),
                             Wdir = row.Field<string>("wind_dir_degrees"),
                             Wspd = row.Field<string>("wind_speed_kt"),
                             Altim = row.Field<string>("altim_in_hg"),
                             FLight_Category = row.Field<string>("flight_category")
                         };

            Thread.Sleep(60000);
            //Console.WriteLine(reps2);
        }
    }
}






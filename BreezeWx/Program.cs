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
using BreezeWx.Models;

namespace Breezewx
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            //This is from the API live
            ApiClient hClient = new ApiClient();

            //hClient.CanApproach();

            //MetarClass reps2 = await hClient.GetMetar("KCRQ");
            //MetarClass reps3 = await hClient.GetMetar("KPDX");

            //CityPairClass cityPair = await hClient.GetCityPairInfo("KSEA", "KPDX");


            //This is from a CSV file
            IngestWxAPIClass wx = new IngestWxAPIClass(@"C:\Users\jd\Downloads\metars.csv");
            var cityPair = wx.GetCityPair("KPDX", "KPDX");
            //DataTable wxDT = wx._metarDataTable;

            //Returns one
            //var dr = wxDT.Select("station_id = 'KSEA'");


            //string time = metars.FirstOrDefault().ObsTime;

            //var metars = from row in wxDT.AsEnumerable()
            //             where row.Field<string>("station_id").Equals("KSEA") || row.Field<string>("station_id").Equals("KPDX")
            //             select new MetarClass
            //             {
            //                 stationId = row.Field<string>("station_id"),
            //                 icaoId = row.Field<string>("icao_id"),
            //                 receiptTime = row.Field<string>("receipt_time"),
            //                 obsTime = DateTime.Parse(row.Field<string>("observation_time")),
            //                 reportTime = row.Field<string>("report_time"),
            //                 temp = row.Field<float?>("temp_c"),
            //                 dewp = row.Field<float?>("dewpoint_c"),
            //                 wdir = row.Field<int?>("wind_dir_degrees"),
            //                 wspd = row.Field<int?>("wind_speed_kt"),
            //                 wgst = row.Field<object>("wind_gust_kt"),
            //                 visib = row.Field<string>("visibility_statute_mi"),
            //                 altim = row.Field<float?>("altim_in_hg"),
            //                 slp = row.Field<float?>("slp_in_hg"),
            //                 qcField = row.Field<int?>("qc_field"),
            //                 wxString = row.Field<object>("wx_string"),
            //                 presTend = row.Field<float?>("pressure_tendency_mb"),
            //                 maxT = row.Field<object>("max_temp_c"),
            //                 minT = row.Field<object>("min_temp_c"),
            //                 maxT24 = row.Field<object>("max_temp24hr_c"),
            //                 minT24 = row.Field<object>("min_temp24hr_c"),
            //                 precip = row.Field<object>("precip_inch"),
            //                 pcp3hr = row.Field<object>("pcp3hr_inch"),
            //                 pcp6hr = row.Field<object>("pcp6hr_inch"),
            //                 pcp24hr = row.Field<object>("pcp24hr_inch"),
            //                 snow = row.Field<object>("snow_inch"),
            //                 vertVis = row.Field<object>("vert_vis_ft_agl"),
            //                 metarType = row.Field<string>("metar_type"),
            //                 rawOb = row.Field<string>("raw_text"),
            //                 mostRecent = row.Field<int?>("most_recent_metar_flag"),
            //                 lat = row.Field<float?>("latitude_deg"),
            //                 lon = row.Field<float?>("longitude_deg"),
            //                 elev = row.Field<int?>("elevation_ft_msl")
            //             };

            //string time = metars.FirstOrDefault().obsTime;

            Thread.Sleep(60000);
            //Console.WriteLine(reps2);
        }
    }
}






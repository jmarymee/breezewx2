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

            hClient.CanApproach();

            MetarClass reps2 = await hClient.GetMetar("KSEA");
            MetarClass reps3 = await hClient.GetMetar("KPDX");

            CityPairClass cityPair = await hClient.GetCityPairInfo("KSEA", "KPDX");


            //This is from a CSV file
            IngestWxAPIClass wx = new IngestWxAPIClass();
            DataTable wxDT = wx.GetDataTabletFromCSVFile(@"C:\Users\jd\Downloads\metars.csv");

            //Returns one
            var dr = wxDT.Select("station_id = 'KSEA'");

            //Can return city pairs and calculate distance
            var metars = from row in wxDT.AsEnumerable()
                         where row.Field<string>("station_id").Equals("KSEA") || row.Field<string>("station_id").Equals("KPDX")
                         select new
                         {
                             StationId = row.Field<string>("station_id"),
                             Latitude = row.Field<string>("latitude"),
                             Longitude = row.Field<string>("longitude"),
                             RawText = row.Field<string>("raw_text"),
                             ObsTime = row.Field<string>("observation_time"),
                             Temp = row.Field<string>("temp_c"),
                             Dewp = row.Field<string>("dewpoint_c"),
                             Wdir = row.Field<string>("wind_dir_degrees"),
                             Wspd = row.Field<string>("wind_speed_kt"),
                             Gusts = row.Field<string>("wind_gust_kt"),
                             Vis = row.Field<string>("visibility_statute_mi"),
                             Altim = row.Field<string>("altim_in_hg"),
                             WXString = row.Field<string>("wx_string"),
                             SkyCoverage = row.Field<string>("sky_cover"),
                             CloudBase = row.Field<string>("cloud_base_ft_agl"),
                             MetarType = row.Field<string>("metar_type"),
                             VertVis = row.Field<string>("vert_vis_ft"),
                             FLight_Category = row.Field<string>("flight_category")
                         };

            string time = metars.FirstOrDefault().ObsTime;

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






﻿using BreezeWx.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BreezeWx
{
    public class IngestWxAPIClass
    {
        public DataTable _metarDataTable { get; set; }

        //How we init the METAR Table
        public IngestWxAPIClass(string filePathToCSV)
        {
            _metarDataTable = GetDataTabletFromCSVFile(filePathToCSV);
        }

        public CityPairClass GetCityPair(string depart, string destination)
        {
            var city1 = GetMetarForCity(depart);

            var cityPair = new CityPairClass();
            return cityPair;
        }

        public MetarClass GetMetarForCity(string cityName)
        {
            MetarClass city = new MetarClass();

            //Can return city pairs and calculate distance
            var metars = from row in _metarDataTable.AsEnumerable()
                         where row.Field<string>("station_id").Equals(cityName) //|| row.Field<string>("station_id").Equals("KPDX")
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
                             SkyCoverage1 = row.Field<string>("sky_cover1"),
                             CloudBase1 = row.Field<string>("cloud_base_ft_agl1"),
                             SkyCoverage2 = row.Field<string>("sky_cover2"),
                             CloudBase2 = row.Field<string>("cloud_base_ft_agl2"),
                             SkyCoverage3 = row.Field<string>("sky_cover3"),
                             CloudBase3 = row.Field<string>("cloud_base_ft_agl3"),
                             MetarType = row.Field<string>("metar_type"),
                             VertVis = row.Field<string>("vert_vis_ft"),
                             FLight_Category = row.Field<string>("flight_category")
                         };

            var cy = metars.FirstOrDefault();

            city.icaoId = cy.StationId;
            city.wdir = cy.Wdir;
            city.wspd = cy.Wspd;
            city.wgst = cy.Gusts;
            city.visib = cy.Vis;

            var clouds = new List<Cloud>();

            //Sky Coverage - first layer. If CLR then it's easy and we are done
            if (cy.SkyCoverage.Equals("CLR"))
            {
                //clouds.Add(new Cloud() { cover = cy.SkyCoverage, @base = int.Parse(cy.CloudBase) });
                clouds.Add(new Cloud() { cover = cy.SkyCoverage, @base = null });
            }
            else
            {
                clouds.Add(new Cloud() { cover = cy.SkyCoverage, @base = int.Parse(cy.CloudBase) });
            }

            //Sky coverage 2
            if (!String.IsNullOrEmpty(cy.SkyCoverage1))
            {
                clouds.Add(new Cloud() { cover = cy.SkyCoverage1, @base = int.Parse(cy.CloudBase1) });
            }

            //Sky Coverage 3
            if (!String.IsNullOrEmpty(cy.SkyCoverage2))
            {
                clouds.Add(new Cloud() { cover = cy.SkyCoverage2, @base = int.Parse(cy.CloudBase2) });
            }

            //Sky Coverage 3
            if (!String.IsNullOrEmpty(cy.SkyCoverage3))
            {
                clouds.Add(new Cloud() { cover = cy.SkyCoverage3, @base = int.Parse(cy.CloudBase3) });
            }

            //Now add to the layers list
            city.clouds = clouds.ToArray();


            return city;
        }

        /// <summary>
        /// For any lat/long this method returns the great circle distance between two points on the Earth
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lon1"></param>
        /// <param name="lat2"></param>
        /// <param name="lon2"></param>
        /// <returns></returns>
        public static float GetHaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 3437.5; //Radius of the earth in NM //6371; // Radius of the Earth in kilometers

            double lat1Rad = ToRadians(lat1);
            double lon1Rad = ToRadians(lon1);
            double lat2Rad = ToRadians(lat2);
            double lon2Rad = ToRadians(lon2);

            double dLat = lat2Rad - lat1Rad;
            double dLon = lon2Rad - lon1Rad;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            //double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double c = 2 * Math.Asin(Math.Sqrt(a));

            return (float) (R * c);

            //double a = Math.Pow(Math.Sin(dLat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dLon / 2), 2);
            //double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return (float)(R * c);

        }

        private static double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

        /// <summary>
        /// This method reads from a CSV file and attempts to parse it into a DataTable object
        /// It uses a TextFieldParser object to read the CSV file based on a VB Class Library
        /// </summary>
        /// <param name="csv_file_path"></param>
        /// <returns>A DataTable that contains all the rows</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            if (!File.Exists(csv_file_path))
            {
                throw new FileNotFoundException("File not found", csv_file_path);
            }

            var csvData = new DataTable("METAR_Data");
            _metarDataTable = csvData;

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.ReadLine(); // Skip the 5 lines
                    csvReader.ReadLine(); // Skip the 5 lines
                    csvReader.ReadLine(); // Skip the 5 lines
                    csvReader.ReadLine(); // Skip the 5 lines
                    csvReader.ReadLine(); // Skip the 5 lines


                    csvReader.SetDelimiters(new string[]
                    {
                        ","
                    });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();

                    //A little defensive programming
                    if (!colFields[0].Equals("raw_text")) //This should be the first header of the data set
                    {
                        throw new Exception("METAR file format not apparent");
                    }

                    //Fixup for DataTable for uniqueness - only for METAR file. Each column for a Data Table must be unique
                    colFields[24] = "sky_cover1";
                    colFields[25] = "cloud_base_ft_agl1";
                    colFields[26] = "sky_cover2";
                    colFields[27] = "cloud_base_ft_agl2";
                    colFields[28] = "sky_cover3";
                    colFields[29] = "cloud_base_ft_agl3";

                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == string.Empty)
                            {
                                fieldData[i] = string.Empty; //fieldData[i] = null
                            }
                            //Skip rows that have any csv header information or blank rows in them
                            if (fieldData[0].Contains("Disclaimer") || string.IsNullOrEmpty(fieldData[0]))
                            {
                                continue;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return csvData;
        }
    }
}

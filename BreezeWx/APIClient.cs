﻿using BreezeWx.Models;
using SuperConvert.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BreezeWx
{
    public class ApiClient
    {
        private readonly HttpClient client = new HttpClient();

        public ApiClient()
        {
            client.BaseAddress = new Uri("https://aviationweather.gov/api/data/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("User-Agent", "Breezewx");
        }

        /// <summary>
        /// This method will look at the airframe and the approach types and determine if the aircraft can approach. That includes and MEL deferred items
        /// </summary>
        /// <returns></returns>
        public bool CanApproach()
        { 
            Models.ApproachTypesFlags airplane = Models.ApproachTypesFlags.CATI | ApproachTypesFlags.RNP;
            Models.ApproachTypesFlags ksea = Models.ApproachTypesFlags.CATIII | Models.ApproachTypesFlags.CATII | Models.ApproachTypesFlags.LPV;

            var canAppraoch = airplane & ksea;

            if (canAppraoch >0) { return true; }
            else { return false; }
        }

        public async Task<string> GetApiResponseAsync(string url)
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

        public async Task<CityPairClass> GetCityPairInfo(string dep, string arr)
        {
            CityPairClass cityPair = new CityPairClass();

            var departureAirport = await GetMetar(dep);
            var arrivalAirport = await GetMetar(arr);
            float distance = IngestWxAPIClass.GetHaversineDistance(departureAirport.lat, departureAirport.lon, arrivalAirport.lat, arrivalAirport.lon);

            cityPair.DepAirport = departureAirport;
            cityPair.ArrAirport = arrivalAirport;
            cityPair.Distance = distance;

            return cityPair;
        }

        public async Task<String> GetMetarXML(string icao)
        {
            HttpResponseMessage response = await client.GetAsync("metar?ids=" + icao + "&format=xml");

            string respBody = await response.Content.ReadAsStringAsync();

            var myXM = ParseXmlToClass<response> (respBody);

            //var retXML = ParseXmlFileToArray<responseData>(@"C:\Users\jd\Downloads\metars.xml");
            var retXML = ParseXmlFileToArray<response>(@"C:\Users\jd\Downloads\metars.xml", typeof(response));

            return respBody;
        }

        public static T ParseXmlToClass<T>(string xmlString) where T : class
        {
            if (string.IsNullOrWhiteSpace(xmlString))
                throw new ArgumentException("XML string cannot be null or empty.", nameof(xmlString));

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xmlString))
            {
                return serializer.Deserialize(reader) as T;
            }
        }

        public static T[] ParseXmlFileToArray<T>(string filePath) where T : class
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified XML file was not found.", filePath);

            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T[])serializer.Deserialize(fileStream);
            }
        }

        //This parses an XML file as a response type into an array of METARS
        
        public static T ParseXmlFileToArray<T>(string filePath, Type type) where T : class
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified XML file was not found.", filePath);
            XmlSerializer serializer = new XmlSerializer(type);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }

        public async Task<MetarClass> GetMetar(string icao)
        {

            try
            {
                //client.BaseAddress = new Uri("https://aviationweather.gov/api/data/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Add("User-Agent", "Breezewx");

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

        // The casts to object in the below code are an unfortunate necessity due to
        // C#'s restriction against a where T : Enum constraint. (There are ways around
        // this, but they're outside the scope of this simple illustration.)
        public static class FlagsHelper
        {
            public static bool IsSet<T>(T flags, T flag) where T : struct
            {
                int flagsValue = (int)(object)flags;
                int flagValue = (int)(object)flag;

                return (flagsValue & flagValue) != 0;
            }

            public static void Set<T>(ref T flags, T flag) where T : struct
            {
                int flagsValue = (int)(object)flags;
                int flagValue = (int)(object)flag;

                flags = (T)(object)(flagsValue | flagValue);
            }

            public static void Unset<T>(ref T flags, T flag) where T : struct
            {
                int flagsValue = (int)(object)flags;
                int flagValue = (int)(object)flag;

                flags = (T)(object)(flagsValue & (~flagValue));
            }
        }
        //Example for using this masking utility:
        /*  Names names = Names.Susan | Names.Bob;

            bool susanIsIncluded = FlagsHelper.IsSet(names, Names.Susan);

            bool karenIsIncluded = FlagsHelper.IsSet(names, Names.Karen);
        */
    }
}

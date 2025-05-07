using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeWx
{
    public class IngestWxAPIClass
    {
        public DataTable _metarDataTable { get; set; }

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

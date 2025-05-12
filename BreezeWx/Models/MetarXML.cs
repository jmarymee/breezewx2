namespace BreezeWx.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class response
    {

        private uint request_indexField;

        private responseData_source data_sourceField;

        private responseRequest requestField;

        private object errorsField;

        private object warningsField;

        private byte time_taken_msField;

        private responseData dataField;

        private decimal versionField;

        /// <remarks/>
        public uint request_index
        {
            get
            {
                return this.request_indexField;
            }
            set
            {
                this.request_indexField = value;
            }
        }

        /// <remarks/>
        public responseData_source data_source
        {
            get
            {
                return this.data_sourceField;
            }
            set
            {
                this.data_sourceField = value;
            }
        }

        /// <remarks/>
        public responseRequest request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        public object errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        /// <remarks/>
        public object warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        public byte time_taken_ms
        {
            get
            {
                return this.time_taken_msField;
            }
            set
            {
                this.time_taken_msField = value;
            }
        }

        /// <remarks/>
        public responseData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseData_source
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRequest
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseData
    {

        private responseDataMETAR mETARField;

        private byte num_resultsField;

        /// <remarks/>
        public responseDataMETAR METAR
        {
            get
            {
                return this.mETARField;
            }
            set
            {
                this.mETARField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte num_results
        {
            get
            {
                return this.num_resultsField;
            }
            set
            {
                this.num_resultsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseDataMETAR
    {

        private string raw_textField;

        private string station_idField;

        private System.DateTime observation_timeField;

        private decimal latitudeField;

        private decimal longitudeField;

        private decimal temp_cField;

        private byte dewpoint_cField;

        private byte wind_dir_degreesField;

        private byte wind_speed_ktField;

        private string visibility_statute_miField;

        private decimal altim_in_hgField;

        private decimal sea_level_pressure_mbField;

        private responseDataMETARQuality_control_flags quality_control_flagsField;

        private string wx_stringField;

        private responseDataMETARSky_condition[] sky_conditionField;

        private string flight_categoryField;

        private decimal precip_inField;

        private string metar_typeField;

        private byte elevation_mField;

        /// <remarks/>
        public string raw_text
        {
            get
            {
                return this.raw_textField;
            }
            set
            {
                this.raw_textField = value;
            }
        }

        /// <remarks/>
        public string station_id
        {
            get
            {
                return this.station_idField;
            }
            set
            {
                this.station_idField = value;
            }
        }

        /// <remarks/>
        public System.DateTime observation_time
        {
            get
            {
                return this.observation_timeField;
            }
            set
            {
                this.observation_timeField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal temp_c
        {
            get
            {
                return this.temp_cField;
            }
            set
            {
                this.temp_cField = value;
            }
        }

        /// <remarks/>
        public byte dewpoint_c
        {
            get
            {
                return this.dewpoint_cField;
            }
            set
            {
                this.dewpoint_cField = value;
            }
        }

        /// <remarks/>
        public byte wind_dir_degrees
        {
            get
            {
                return this.wind_dir_degreesField;
            }
            set
            {
                this.wind_dir_degreesField = value;
            }
        }

        /// <remarks/>
        public byte wind_speed_kt
        {
            get
            {
                return this.wind_speed_ktField;
            }
            set
            {
                this.wind_speed_ktField = value;
            }
        }

        /// <remarks/>
        public string visibility_statute_mi
        {
            get
            {
                return this.visibility_statute_miField;
            }
            set
            {
                this.visibility_statute_miField = value;
            }
        }

        /// <remarks/>
        public decimal altim_in_hg
        {
            get
            {
                return this.altim_in_hgField;
            }
            set
            {
                this.altim_in_hgField = value;
            }
        }

        /// <remarks/>
        public decimal sea_level_pressure_mb
        {
            get
            {
                return this.sea_level_pressure_mbField;
            }
            set
            {
                this.sea_level_pressure_mbField = value;
            }
        }

        /// <remarks/>
        public responseDataMETARQuality_control_flags quality_control_flags
        {
            get
            {
                return this.quality_control_flagsField;
            }
            set
            {
                this.quality_control_flagsField = value;
            }
        }

        /// <remarks/>
        public string wx_string
        {
            get
            {
                return this.wx_stringField;
            }
            set
            {
                this.wx_stringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sky_condition")]
        public responseDataMETARSky_condition[] sky_condition
        {
            get
            {
                return this.sky_conditionField;
            }
            set
            {
                this.sky_conditionField = value;
            }
        }

        /// <remarks/>
        public string flight_category
        {
            get
            {
                return this.flight_categoryField;
            }
            set
            {
                this.flight_categoryField = value;
            }
        }

        /// <remarks/>
        public decimal precip_in
        {
            get
            {
                return this.precip_inField;
            }
            set
            {
                this.precip_inField = value;
            }
        }

        /// <remarks/>
        public string metar_type
        {
            get
            {
                return this.metar_typeField;
            }
            set
            {
                this.metar_typeField = value;
            }
        }

        /// <remarks/>
        public byte elevation_m
        {
            get
            {
                return this.elevation_mField;
            }
            set
            {
                this.elevation_mField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseDataMETARQuality_control_flags
    {

        private string auto_stationField;

        private string maintenance_indicator_onField;

        /// <remarks/>
        public string auto_station
        {
            get
            {
                return this.auto_stationField;
            }
            set
            {
                this.auto_stationField = value;
            }
        }

        /// <remarks/>
        public string maintenance_indicator_on
        {
            get
            {
                return this.maintenance_indicator_onField;
            }
            set
            {
                this.maintenance_indicator_onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseDataMETARSky_condition
    {

        private string sky_coverField;

        private ushort cloud_base_ft_aglField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sky_cover
        {
            get
            {
                return this.sky_coverField;
            }
            set
            {
                this.sky_coverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort cloud_base_ft_agl
        {
            get
            {
                return this.cloud_base_ft_aglField;
            }
            set
            {
                this.cloud_base_ft_aglField = value;
            }
        }
    }
}


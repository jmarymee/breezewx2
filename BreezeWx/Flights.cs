
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
public partial class Envelope
{

    private EnvelopeBody bodyField;

    /// <remarks/>
    public EnvelopeBody Body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody
{

    private GetFlightsResponse getFlightsResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://raido.aviolinx.com/api/")]
    public GetFlightsResponse GetFlightsResponse
    {
        get
        {
            return this.getFlightsResponseField;
        }
        set
        {
            this.getFlightsResponseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://raido.aviolinx.com/api/", IsNullable = false)]
public partial class GetFlightsResponse
{

    private GetFlightsResponseFlight[] getFlightsResultField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Flight", IsNullable = false)]
    public GetFlightsResponseFlight[] GetFlightsResult
    {
        get
        {
            return this.getFlightsResultField;
        }
        set
        {
            this.getFlightsResultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlight
{

    private uint uniqueIdField;

    private string airlineCodeField;

    private string iCAOAirlineCodeField;

    private ushort flightNumberField;

    private object suffixField;

    private string departureAirportCodeField;

    private string arrivalAirportCodeField;

    private object diversionAirportCodeField;

    private System.DateTime flightDateField;

    private System.DateTime sTDField;

    private System.DateTime sTAField;

    private string aircraftRegistrationField;

    private string serviceTypeCodeField;

    private string onwardAirlineCodeField;

    private ushort onwardFlightNumberField;

    private object onwardSuffixField;

    private string statusField;

    private string typeField;

    private bool canceledField;

    private short departureLocalTimeDiffField;

    private short arrivalLocalTimeDiffField;

    private object aSMReasonsField;

    private string complementField;

    private decimal cO2Field;

    private ushort scheduleGCDKMField;

    private ushort scheduleGCDNMField;

    private GetFlightsResponseFlightAircraft aircraftField;

    private GetFlightsResponseFlightAirports airportsField;

    private GetFlightsResponseFlightCrewOnBoard[] crewOnBoardField;

    private GetFlightsResponseFlightDelays delaysField;

    private GetFlightsResponseFlightFlightplan flightplanField;

    private GetFlightsResponseFlightFuel[] fuelsField;

    private GetFlightsResponseFlightLoads loadsField;

    private object notesField;

    private GetFlightsResponseFlightTime[] timesField;

    private GetFlightsResponseFlightLatts lattsField;

    private GetFlightsResponseFlightRoundtrip roundtripField;

    private object projectCodesField;

    private object legalExceptionsField;

    private object jumpseatersField;

    private GetFlightsResponseFlightFuelData fuelDataField;

    private string[] detailedStatusesField;

    private string deskField;

    /// <remarks/>
    public uint UniqueId
    {
        get
        {
            return this.uniqueIdField;
        }
        set
        {
            this.uniqueIdField = value;
        }
    }

    /// <remarks/>
    public string AirlineCode
    {
        get
        {
            return this.airlineCodeField;
        }
        set
        {
            this.airlineCodeField = value;
        }
    }

    /// <remarks/>
    public string ICAOAirlineCode
    {
        get
        {
            return this.iCAOAirlineCodeField;
        }
        set
        {
            this.iCAOAirlineCodeField = value;
        }
    }

    /// <remarks/>
    public ushort FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    public object Suffix
    {
        get
        {
            return this.suffixField;
        }
        set
        {
            this.suffixField = value;
        }
    }

    /// <remarks/>
    public string DepartureAirportCode
    {
        get
        {
            return this.departureAirportCodeField;
        }
        set
        {
            this.departureAirportCodeField = value;
        }
    }

    /// <remarks/>
    public string ArrivalAirportCode
    {
        get
        {
            return this.arrivalAirportCodeField;
        }
        set
        {
            this.arrivalAirportCodeField = value;
        }
    }

    /// <remarks/>
    public object DiversionAirportCode
    {
        get
        {
            return this.diversionAirportCodeField;
        }
        set
        {
            this.diversionAirportCodeField = value;
        }
    }

    /// <remarks/>
    public System.DateTime FlightDate
    {
        get
        {
            return this.flightDateField;
        }
        set
        {
            this.flightDateField = value;
        }
    }

    /// <remarks/>
    public System.DateTime STD
    {
        get
        {
            return this.sTDField;
        }
        set
        {
            this.sTDField = value;
        }
    }

    /// <remarks/>
    public System.DateTime STA
    {
        get
        {
            return this.sTAField;
        }
        set
        {
            this.sTAField = value;
        }
    }

    /// <remarks/>
    public string AircraftRegistration
    {
        get
        {
            return this.aircraftRegistrationField;
        }
        set
        {
            this.aircraftRegistrationField = value;
        }
    }

    /// <remarks/>
    public string ServiceTypeCode
    {
        get
        {
            return this.serviceTypeCodeField;
        }
        set
        {
            this.serviceTypeCodeField = value;
        }
    }

    /// <remarks/>
    public string OnwardAirlineCode
    {
        get
        {
            return this.onwardAirlineCodeField;
        }
        set
        {
            this.onwardAirlineCodeField = value;
        }
    }

    /// <remarks/>
    public ushort OnwardFlightNumber
    {
        get
        {
            return this.onwardFlightNumberField;
        }
        set
        {
            this.onwardFlightNumberField = value;
        }
    }

    /// <remarks/>
    public object OnwardSuffix
    {
        get
        {
            return this.onwardSuffixField;
        }
        set
        {
            this.onwardSuffixField = value;
        }
    }

    /// <remarks/>
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string Type
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

    /// <remarks/>
    public bool Canceled
    {
        get
        {
            return this.canceledField;
        }
        set
        {
            this.canceledField = value;
        }
    }

    /// <remarks/>
    public short DepartureLocalTimeDiff
    {
        get
        {
            return this.departureLocalTimeDiffField;
        }
        set
        {
            this.departureLocalTimeDiffField = value;
        }
    }

    /// <remarks/>
    public short ArrivalLocalTimeDiff
    {
        get
        {
            return this.arrivalLocalTimeDiffField;
        }
        set
        {
            this.arrivalLocalTimeDiffField = value;
        }
    }

    /// <remarks/>
    public object ASMReasons
    {
        get
        {
            return this.aSMReasonsField;
        }
        set
        {
            this.aSMReasonsField = value;
        }
    }

    /// <remarks/>
    public string Complement
    {
        get
        {
            return this.complementField;
        }
        set
        {
            this.complementField = value;
        }
    }

    /// <remarks/>
    public decimal CO2
    {
        get
        {
            return this.cO2Field;
        }
        set
        {
            this.cO2Field = value;
        }
    }

    /// <remarks/>
    public ushort ScheduleGCDKM
    {
        get
        {
            return this.scheduleGCDKMField;
        }
        set
        {
            this.scheduleGCDKMField = value;
        }
    }

    /// <remarks/>
    public ushort ScheduleGCDNM
    {
        get
        {
            return this.scheduleGCDNMField;
        }
        set
        {
            this.scheduleGCDNMField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightAircraft Aircraft
    {
        get
        {
            return this.aircraftField;
        }
        set
        {
            this.aircraftField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightAirports Airports
    {
        get
        {
            return this.airportsField;
        }
        set
        {
            this.airportsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CrewOnBoard", IsNullable = false)]
    public GetFlightsResponseFlightCrewOnBoard[] CrewOnBoard
    {
        get
        {
            return this.crewOnBoardField;
        }
        set
        {
            this.crewOnBoardField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightDelays Delays
    {
        get
        {
            return this.delaysField;
        }
        set
        {
            this.delaysField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightFlightplan Flightplan
    {
        get
        {
            return this.flightplanField;
        }
        set
        {
            this.flightplanField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Fuel", IsNullable = false)]
    public GetFlightsResponseFlightFuel[] Fuels
    {
        get
        {
            return this.fuelsField;
        }
        set
        {
            this.fuelsField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightLoads Loads
    {
        get
        {
            return this.loadsField;
        }
        set
        {
            this.loadsField = value;
        }
    }

    /// <remarks/>
    public object Notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Time", IsNullable = false)]
    public GetFlightsResponseFlightTime[] Times
    {
        get
        {
            return this.timesField;
        }
        set
        {
            this.timesField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightLatts Latts
    {
        get
        {
            return this.lattsField;
        }
        set
        {
            this.lattsField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightRoundtrip Roundtrip
    {
        get
        {
            return this.roundtripField;
        }
        set
        {
            this.roundtripField = value;
        }
    }

    /// <remarks/>
    public object ProjectCodes
    {
        get
        {
            return this.projectCodesField;
        }
        set
        {
            this.projectCodesField = value;
        }
    }

    /// <remarks/>
    public object LegalExceptions
    {
        get
        {
            return this.legalExceptionsField;
        }
        set
        {
            this.legalExceptionsField = value;
        }
    }

    /// <remarks/>
    public object Jumpseaters
    {
        get
        {
            return this.jumpseatersField;
        }
        set
        {
            this.jumpseatersField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightFuelData FuelData
    {
        get
        {
            return this.fuelDataField;
        }
        set
        {
            this.fuelDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DetailedStatus", IsNullable = false)]
    public string[] DetailedStatuses
    {
        get
        {
            return this.detailedStatusesField;
        }
        set
        {
            this.detailedStatusesField = value;
        }
    }

    /// <remarks/>
    public string Desk
    {
        get
        {
            return this.deskField;
        }
        set
        {
            this.deskField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAircraft
{

    private ushort uniqueIdField;

    private string registrationField;

    private byte typeField;

    private string versionField;

    private string configField;

    private object serialNumberField;

    private string nameField;

    private object nickNameField;

    /// <remarks/>
    public ushort UniqueId
    {
        get
        {
            return this.uniqueIdField;
        }
        set
        {
            this.uniqueIdField = value;
        }
    }

    /// <remarks/>
    public string Registration
    {
        get
        {
            return this.registrationField;
        }
        set
        {
            this.registrationField = value;
        }
    }

    /// <remarks/>
    public byte Type
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

    /// <remarks/>
    public string Version
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

    /// <remarks/>
    public string Config
    {
        get
        {
            return this.configField;
        }
        set
        {
            this.configField = value;
        }
    }

    /// <remarks/>
    public object SerialNumber
    {
        get
        {
            return this.serialNumberField;
        }
        set
        {
            this.serialNumberField = value;
        }
    }

    /// <remarks/>
    public string Name
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

    /// <remarks/>
    public object NickName
    {
        get
        {
            return this.nickNameField;
        }
        set
        {
            this.nickNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAirports
{

    private GetFlightsResponseFlightAirportsDepartureAirport departureAirportField;

    private GetFlightsResponseFlightAirportsArrivalAirport arrivalAirportField;

    private GetFlightsResponseFlightAirportsScheduleDepartureAirport scheduleDepartureAirportField;

    private GetFlightsResponseFlightAirportsScheduleArrivalAirport scheduleArrivalAirportField;

    /// <remarks/>
    public GetFlightsResponseFlightAirportsDepartureAirport DepartureAirport
    {
        get
        {
            return this.departureAirportField;
        }
        set
        {
            this.departureAirportField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightAirportsArrivalAirport ArrivalAirport
    {
        get
        {
            return this.arrivalAirportField;
        }
        set
        {
            this.arrivalAirportField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightAirportsScheduleDepartureAirport ScheduleDepartureAirport
    {
        get
        {
            return this.scheduleDepartureAirportField;
        }
        set
        {
            this.scheduleDepartureAirportField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightAirportsScheduleArrivalAirport ScheduleArrivalAirport
    {
        get
        {
            return this.scheduleArrivalAirportField;
        }
        set
        {
            this.scheduleArrivalAirportField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAirportsDepartureAirport
{

    private string nameField;

    private string cityNameField;

    private object localNameField;

    private string iATAField;

    private string iCAOField;

    private string countryField;

    private string gateField;

    private object standField;

    private decimal latitudeField;

    private decimal longitudeField;

    private string slotLevelField;

    /// <remarks/>
    public string Name
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

    /// <remarks/>
    public string CityName
    {
        get
        {
            return this.cityNameField;
        }
        set
        {
            this.cityNameField = value;
        }
    }

    /// <remarks/>
    public object LocalName
    {
        get
        {
            return this.localNameField;
        }
        set
        {
            this.localNameField = value;
        }
    }

    /// <remarks/>
    public string IATA
    {
        get
        {
            return this.iATAField;
        }
        set
        {
            this.iATAField = value;
        }
    }

    /// <remarks/>
    public string ICAO
    {
        get
        {
            return this.iCAOField;
        }
        set
        {
            this.iCAOField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public string Gate
    {
        get
        {
            return this.gateField;
        }
        set
        {
            this.gateField = value;
        }
    }

    /// <remarks/>
    public object Stand
    {
        get
        {
            return this.standField;
        }
        set
        {
            this.standField = value;
        }
    }

    /// <remarks/>
    public decimal Latitude
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
    public decimal Longitude
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
    public string SlotLevel
    {
        get
        {
            return this.slotLevelField;
        }
        set
        {
            this.slotLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAirportsArrivalAirport
{

    private string nameField;

    private string cityNameField;

    private object localNameField;

    private string iATAField;

    private string iCAOField;

    private string countryField;

    private string gateField;

    private string standField;

    private decimal latitudeField;

    private decimal longitudeField;

    private string slotLevelField;

    /// <remarks/>
    public string Name
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

    /// <remarks/>
    public string CityName
    {
        get
        {
            return this.cityNameField;
        }
        set
        {
            this.cityNameField = value;
        }
    }

    /// <remarks/>
    public object LocalName
    {
        get
        {
            return this.localNameField;
        }
        set
        {
            this.localNameField = value;
        }
    }

    /// <remarks/>
    public string IATA
    {
        get
        {
            return this.iATAField;
        }
        set
        {
            this.iATAField = value;
        }
    }

    /// <remarks/>
    public string ICAO
    {
        get
        {
            return this.iCAOField;
        }
        set
        {
            this.iCAOField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public string Gate
    {
        get
        {
            return this.gateField;
        }
        set
        {
            this.gateField = value;
        }
    }

    /// <remarks/>
    public string Stand
    {
        get
        {
            return this.standField;
        }
        set
        {
            this.standField = value;
        }
    }

    /// <remarks/>
    public decimal Latitude
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
    public decimal Longitude
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
    public string SlotLevel
    {
        get
        {
            return this.slotLevelField;
        }
        set
        {
            this.slotLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAirportsScheduleDepartureAirport
{

    private string nameField;

    private string cityNameField;

    private object localNameField;

    private string iATAField;

    private string iCAOField;

    private string countryField;

    private decimal latitudeField;

    private decimal longitudeField;

    private string slotLevelField;

    /// <remarks/>
    public string Name
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

    /// <remarks/>
    public string CityName
    {
        get
        {
            return this.cityNameField;
        }
        set
        {
            this.cityNameField = value;
        }
    }

    /// <remarks/>
    public object LocalName
    {
        get
        {
            return this.localNameField;
        }
        set
        {
            this.localNameField = value;
        }
    }

    /// <remarks/>
    public string IATA
    {
        get
        {
            return this.iATAField;
        }
        set
        {
            this.iATAField = value;
        }
    }

    /// <remarks/>
    public string ICAO
    {
        get
        {
            return this.iCAOField;
        }
        set
        {
            this.iCAOField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public decimal Latitude
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
    public decimal Longitude
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
    public string SlotLevel
    {
        get
        {
            return this.slotLevelField;
        }
        set
        {
            this.slotLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightAirportsScheduleArrivalAirport
{

    private string nameField;

    private string cityNameField;

    private object localNameField;

    private string iATAField;

    private string iCAOField;

    private string countryField;

    private decimal latitudeField;

    private decimal longitudeField;

    private string slotLevelField;

    /// <remarks/>
    public string Name
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

    /// <remarks/>
    public string CityName
    {
        get
        {
            return this.cityNameField;
        }
        set
        {
            this.cityNameField = value;
        }
    }

    /// <remarks/>
    public object LocalName
    {
        get
        {
            return this.localNameField;
        }
        set
        {
            this.localNameField = value;
        }
    }

    /// <remarks/>
    public string IATA
    {
        get
        {
            return this.iATAField;
        }
        set
        {
            this.iATAField = value;
        }
    }

    /// <remarks/>
    public string ICAO
    {
        get
        {
            return this.iCAOField;
        }
        set
        {
            this.iCAOField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public decimal Latitude
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
    public decimal Longitude
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
    public string SlotLevel
    {
        get
        {
            return this.slotLevelField;
        }
        set
        {
            this.slotLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightCrewOnBoard
{

    private string assignedRankField;

    private string rosterDesignatorField;

    private object legalExceptionField;

    private GetFlightsResponseFlightCrewOnBoardCrew crewField;

    /// <remarks/>
    public string AssignedRank
    {
        get
        {
            return this.assignedRankField;
        }
        set
        {
            this.assignedRankField = value;
        }
    }

    /// <remarks/>
    public string RosterDesignator
    {
        get
        {
            return this.rosterDesignatorField;
        }
        set
        {
            this.rosterDesignatorField = value;
        }
    }

    /// <remarks/>
    public object LegalException
    {
        get
        {
            return this.legalExceptionField;
        }
        set
        {
            this.legalExceptionField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightCrewOnBoardCrew Crew
    {
        get
        {
            return this.crewField;
        }
        set
        {
            this.crewField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightCrewOnBoardCrew
{

    private bool activeField;

    private ushort uniqueIdField;

    private uint numberField;

    private object code1Field;

    private object code2Field;

    private string firstnameField;

    private object middlenameField;

    private string lastnameField;

    private object nicknameField;

    private string genderField;

    private ushort seniorityField;

    private string baseField;

    private string rankField;

    private string qualificationField;

    private string typeField;

    private System.DateTime createdAtField;

    private System.DateTime modifiedAtField;

    private System.DateTime dateOfEmploymentField;

    private System.DateTime dateOfBirthField;

    /// <remarks/>
    public bool Active
    {
        get
        {
            return this.activeField;
        }
        set
        {
            this.activeField = value;
        }
    }

    /// <remarks/>
    public ushort UniqueId
    {
        get
        {
            return this.uniqueIdField;
        }
        set
        {
            this.uniqueIdField = value;
        }
    }

    /// <remarks/>
    public uint Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public object Code1
    {
        get
        {
            return this.code1Field;
        }
        set
        {
            this.code1Field = value;
        }
    }

    /// <remarks/>
    public object Code2
    {
        get
        {
            return this.code2Field;
        }
        set
        {
            this.code2Field = value;
        }
    }

    /// <remarks/>
    public string Firstname
    {
        get
        {
            return this.firstnameField;
        }
        set
        {
            this.firstnameField = value;
        }
    }

    /// <remarks/>
    public object Middlename
    {
        get
        {
            return this.middlenameField;
        }
        set
        {
            this.middlenameField = value;
        }
    }

    /// <remarks/>
    public string Lastname
    {
        get
        {
            return this.lastnameField;
        }
        set
        {
            this.lastnameField = value;
        }
    }

    /// <remarks/>
    public object Nickname
    {
        get
        {
            return this.nicknameField;
        }
        set
        {
            this.nicknameField = value;
        }
    }

    /// <remarks/>
    public string Gender
    {
        get
        {
            return this.genderField;
        }
        set
        {
            this.genderField = value;
        }
    }

    /// <remarks/>
    public ushort Seniority
    {
        get
        {
            return this.seniorityField;
        }
        set
        {
            this.seniorityField = value;
        }
    }

    /// <remarks/>
    public string Base
    {
        get
        {
            return this.baseField;
        }
        set
        {
            this.baseField = value;
        }
    }

    /// <remarks/>
    public string Rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }

    /// <remarks/>
    public string Qualification
    {
        get
        {
            return this.qualificationField;
        }
        set
        {
            this.qualificationField = value;
        }
    }

    /// <remarks/>
    public string Type
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

    /// <remarks/>
    public System.DateTime CreatedAt
    {
        get
        {
            return this.createdAtField;
        }
        set
        {
            this.createdAtField = value;
        }
    }

    /// <remarks/>
    public System.DateTime ModifiedAt
    {
        get
        {
            return this.modifiedAtField;
        }
        set
        {
            this.modifiedAtField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateOfEmployment
    {
        get
        {
            return this.dateOfEmploymentField;
        }
        set
        {
            this.dateOfEmploymentField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateOfBirth
    {
        get
        {
            return this.dateOfBirthField;
        }
        set
        {
            this.dateOfBirthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightDelays
{

    private GetFlightsResponseFlightDelaysDelay1 delay1Field;

    private GetFlightsResponseFlightDelaysDelay2 delay2Field;

    /// <remarks/>
    public GetFlightsResponseFlightDelaysDelay1 Delay1
    {
        get
        {
            return this.delay1Field;
        }
        set
        {
            this.delay1Field = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightDelaysDelay2 Delay2
    {
        get
        {
            return this.delay2Field;
        }
        set
        {
            this.delay2Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightDelaysDelay1
{

    private string codeField;

    private byte code2Field;

    private byte minutesField;

    /// <remarks/>
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    public byte Code2
    {
        get
        {
            return this.code2Field;
        }
        set
        {
            this.code2Field = value;
        }
    }

    /// <remarks/>
    public byte Minutes
    {
        get
        {
            return this.minutesField;
        }
        set
        {
            this.minutesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightDelaysDelay2
{

    private string codeField;

    private byte code2Field;

    private byte minutesField;

    /// <remarks/>
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    public byte Code2
    {
        get
        {
            return this.code2Field;
        }
        set
        {
            this.code2Field = value;
        }
    }

    /// <remarks/>
    public byte Minutes
    {
        get
        {
            return this.minutesField;
        }
        set
        {
            this.minutesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightFlightplan
{

    private string callsignField;

    private string routeField;

    private byte estimatedElapsedTimeField;

    private string cruisingSpeedLevelField;

    /// <remarks/>
    public string Callsign
    {
        get
        {
            return this.callsignField;
        }
        set
        {
            this.callsignField = value;
        }
    }

    /// <remarks/>
    public string Route
    {
        get
        {
            return this.routeField;
        }
        set
        {
            this.routeField = value;
        }
    }

    /// <remarks/>
    public byte EstimatedElapsedTime
    {
        get
        {
            return this.estimatedElapsedTimeField;
        }
        set
        {
            this.estimatedElapsedTimeField = value;
        }
    }

    /// <remarks/>
    public string CruisingSpeedLevel
    {
        get
        {
            return this.cruisingSpeedLevelField;
        }
        set
        {
            this.cruisingSpeedLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightFuel
{

    private string typeField;

    private string sourceField;

    private decimal quantityField;

    private string quantityUnitField;

    private byte densityField;

    private string densityUnitField;

    /// <remarks/>
    public string Type
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

    /// <remarks/>
    public string Source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    public decimal Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnit
    {
        get
        {
            return this.quantityUnitField;
        }
        set
        {
            this.quantityUnitField = value;
        }
    }

    /// <remarks/>
    public byte Density
    {
        get
        {
            return this.densityField;
        }
        set
        {
            this.densityField = value;
        }
    }

    /// <remarks/>
    public string DensityUnit
    {
        get
        {
            return this.densityUnitField;
        }
        set
        {
            this.densityUnitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoads
{

    private GetFlightsResponseFlightLoadsBookedPassengerPerWeight bookedPassengerPerWeightField;

    private GetFlightsResponseFlightLoadsActualPassengerPerWeight actualPassengerPerWeightField;

    private GetFlightsResponseFlightLoadsBookedPassengerPerClass bookedPassengerPerClassField;

    private GetFlightsResponseFlightLoadsBookedDeadload bookedDeadloadField;

    /// <remarks/>
    public GetFlightsResponseFlightLoadsBookedPassengerPerWeight BookedPassengerPerWeight
    {
        get
        {
            return this.bookedPassengerPerWeightField;
        }
        set
        {
            this.bookedPassengerPerWeightField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightLoadsActualPassengerPerWeight ActualPassengerPerWeight
    {
        get
        {
            return this.actualPassengerPerWeightField;
        }
        set
        {
            this.actualPassengerPerWeightField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightLoadsBookedPassengerPerClass BookedPassengerPerClass
    {
        get
        {
            return this.bookedPassengerPerClassField;
        }
        set
        {
            this.bookedPassengerPerClassField = value;
        }
    }

    /// <remarks/>
    public GetFlightsResponseFlightLoadsBookedDeadload BookedDeadload
    {
        get
        {
            return this.bookedDeadloadField;
        }
        set
        {
            this.bookedDeadloadField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsBookedPassengerPerWeight
{

    private byte adultsField;

    private object malesField;

    private object femalesField;

    private byte childrenField;

    private byte infantsField;

    /// <remarks/>
    public byte Adults
    {
        get
        {
            return this.adultsField;
        }
        set
        {
            this.adultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Males
    {
        get
        {
            return this.malesField;
        }
        set
        {
            this.malesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Females
    {
        get
        {
            return this.femalesField;
        }
        set
        {
            this.femalesField = value;
        }
    }

    /// <remarks/>
    public byte Children
    {
        get
        {
            return this.childrenField;
        }
        set
        {
            this.childrenField = value;
        }
    }

    /// <remarks/>
    public byte Infants
    {
        get
        {
            return this.infantsField;
        }
        set
        {
            this.infantsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsActualPassengerPerWeight
{

    private byte adultsField;

    private object malesField;

    private object femalesField;

    private object childrenField;

    private object infantsField;

    /// <remarks/>
    public byte Adults
    {
        get
        {
            return this.adultsField;
        }
        set
        {
            this.adultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Males
    {
        get
        {
            return this.malesField;
        }
        set
        {
            this.malesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Females
    {
        get
        {
            return this.femalesField;
        }
        set
        {
            this.femalesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Children
    {
        get
        {
            return this.childrenField;
        }
        set
        {
            this.childrenField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object Infants
    {
        get
        {
            return this.infantsField;
        }
        set
        {
            this.infantsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsBookedPassengerPerClass
{

    private GetFlightsResponseFlightLoadsBookedPassengerPerClassPassengerPerClass passengerPerClassField;

    /// <remarks/>
    public GetFlightsResponseFlightLoadsBookedPassengerPerClassPassengerPerClass PassengerPerClass
    {
        get
        {
            return this.passengerPerClassField;
        }
        set
        {
            this.passengerPerClassField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsBookedPassengerPerClassPassengerPerClass
{

    private string classField;

    private byte amountField;

    private byte pADAmountField;

    /// <remarks/>
    public string Class
    {
        get
        {
            return this.classField;
        }
        set
        {
            this.classField = value;
        }
    }

    /// <remarks/>
    public byte Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public byte PADAmount
    {
        get
        {
            return this.pADAmountField;
        }
        set
        {
            this.pADAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsBookedDeadload
{

    private GetFlightsResponseFlightLoadsBookedDeadloadDeadload deadloadField;

    /// <remarks/>
    public GetFlightsResponseFlightLoadsBookedDeadloadDeadload Deadload
    {
        get
        {
            return this.deadloadField;
        }
        set
        {
            this.deadloadField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLoadsBookedDeadloadDeadload
{

    private object compartmentField;

    private string typeField;

    private byte amountField;

    /// <remarks/>
    public object Compartment
    {
        get
        {
            return this.compartmentField;
        }
        set
        {
            this.compartmentField = value;
        }
    }

    /// <remarks/>
    public string Type
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

    /// <remarks/>
    public byte Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightTime
{

    private string typeField;

    private System.DateTime dateTimeField;

    /// <remarks/>
    public string Type
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

    /// <remarks/>
    public System.DateTime DateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLatts
{

    private GetFlightsResponseFlightLattsLatt lattField;

    /// <remarks/>
    public GetFlightsResponseFlightLattsLatt Latt
    {
        get
        {
            return this.lattField;
        }
        set
        {
            this.lattField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightLattsLatt
{

    private object lATTField;

    private object reasonField;

    private object eDCTField;

    private object crewField;

    private byte eETField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object LATT
    {
        get
        {
            return this.lATTField;
        }
        set
        {
            this.lATTField = value;
        }
    }

    /// <remarks/>
    public object Reason
    {
        get
        {
            return this.reasonField;
        }
        set
        {
            this.reasonField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object EDCT
    {
        get
        {
            return this.eDCTField;
        }
        set
        {
            this.eDCTField = value;
        }
    }

    /// <remarks/>
    public object Crew
    {
        get
        {
            return this.crewField;
        }
        set
        {
            this.crewField = value;
        }
    }

    /// <remarks/>
    public byte EET
    {
        get
        {
            return this.eETField;
        }
        set
        {
            this.eETField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightRoundtrip
{

    private object nameField;

    private object numberField;

    /// <remarks/>
    public object Name
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

    /// <remarks/>
    public object Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://raido.aviolinx.com/api/")]
public partial class GetFlightsResponseFlightFuelData
{

    private object companyField;

    private byte costField;

    private object currencyField;

    private string paymentTypeField;

    private object receiptField;

    private object commentField;

    /// <remarks/>
    public object Company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }

    /// <remarks/>
    public byte Cost
    {
        get
        {
            return this.costField;
        }
        set
        {
            this.costField = value;
        }
    }

    /// <remarks/>
    public object Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public string PaymentType
    {
        get
        {
            return this.paymentTypeField;
        }
        set
        {
            this.paymentTypeField = value;
        }
    }

    /// <remarks/>
    public object Receipt
    {
        get
        {
            return this.receiptField;
        }
        set
        {
            this.receiptField = value;
        }
    }

    /// <remarks/>
    public object Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }
}



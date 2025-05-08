using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeWx.Models
{
    public class CityPairClass
    {
        public MetarClass DepAirport { get; set; }
        public MetarClass ArrAirport { get; set; }
        public float Distance { get; set; } // in NM
        public OpSpecsClass? opSpecs { get; set; }
        public bool isFlyable { get; set; }

    }

    public class OpSpecsClass
    {
        public string TakeoffVis { get; set; }
        public string TakeoffCeiling { get; set; }
        public string LandingVis { get; set; }
        public string LandingCeiling { get; set; }
    }

    public class Aircraft
    {
        public string Tail { get; set; }
        public AircraftTYpe acType { get; set; }
        public ApproachTypes approachType { get; set; }

    }

    public enum AircraftTYpe
    {
        A220,
        E190
    }

    public enum ApproachTypes
    {
        ILS,
        RNP,
        RNAV,
        LPV,
        VOR,
        NDB,
        LOC,
        VFR
    }

    [Flags]
    public enum ApproachTypesFlags
    {
        NONE = 0,
        CATIII = 1,
        CATII = 2,
        CATI = 4,
        RNAV = 8,
        LPV = 16,
        MDA = 32,
        RNP = 64,
        CIRCLE = 128,
        VFR = 256
    }
}

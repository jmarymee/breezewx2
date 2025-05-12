
public class Rootobject
{
    public MetarClass[] Property1 { get; set; }
}

public class MetarClass
{
    public int metar_id { get; set; }
    public string icaoId { get; set; }
    public string receiptTime { get; set; }
    public int obsTime { get; set; }
    public string reportTime { get; set; }
    public float temp { get; set; }
    public float dewp { get; set; }
    public object wdir { get; set; }
    public object wspd { get; set; }
    public object wgst { get; set; }
    public string visib { get; set; }
    public float altim { get; set; }
    public object slp { get; set; }
    public int qcField { get; set; }
    public object wxString { get; set; }
    public object presTend { get; set; }
    public object maxT { get; set; }
    public object minT { get; set; }
    public object maxT24 { get; set; }
    public object minT24 { get; set; }
    public object precip { get; set; }
    public object pcp3hr { get; set; }
    public object pcp6hr { get; set; }
    public object pcp24hr { get; set; }
    public object snow { get; set; }
    public object vertVis { get; set; }
    public string metarType { get; set; }
    public string rawOb { get; set; }
    public int mostRecent { get; set; }
    public float lat { get; set; }
    public float lon { get; set; }
    public int elev { get; set; }
    public int prior { get; set; }
    public string name { get; set; }
    public Cloud[] clouds { get; set; }
}

public class Cloud
{
    public string cover { get; set; }
    public int? @base { get; set; }
}

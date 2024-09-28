namespace NASA_InSight.Models
{
    public class WeatherDataModel
    {
        public Dictionary<string,object> solData { get; set; }
        public string[] sol_keys { get; set; }
    }

    public class KVPair
    {
        public string key { get; set; }
        public SOL value { get; set; }
    }
    public class SOL
    {
        public AT AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD WD { get; set; }
    }

    public class AT
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD
    {
        public (float,WindDirection) WindData { get; set; }
        public (string,WindDirection) CommonWindData { get; set; }
    }

    public class WindDirection
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

}


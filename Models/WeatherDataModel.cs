namespace NASA_InSight.Models
{
    public class WeatherDataModel
    {
        public _675 _675 { get; set; }
        public _676 _676 { get; set; }
        public _677 _677 { get; set; }
        public _678 _678 { get; set; }
        public _679 _679 { get; set; }
        public _680 _680 { get; set; }
        public _681 _681 { get; set; }
        public string[] sol_keys { get; set; }
        public Validity_Checks validity_checks { get; set; }
    }

    public class _675
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
        public _0 _0 { get; set; }
        public _1 _1 { get; set; }
        public _9 _9 { get; set; }
        public _10 _10 { get; set; }
        public _11 _11 { get; set; }
        public _12 _12 { get; set; }
        public _13 _13 { get; set; }
        public _14 _14 { get; set; }
        public _15 _15 { get; set; }
        public Most_Common most_common { get; set; }
    }

    public class _0
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _1
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _9
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _10
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _11
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _12
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _13
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _14
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _15
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _676
    {
        public AT1 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS1 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE1 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD1 WD { get; set; }
    }

    public class AT1
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS1
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE1
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD1
    {
        public _01 _0 { get; set; }
        public _16 _1 { get; set; }
        public _2 _2 { get; set; }
        public _5 _5 { get; set; }
        public _101 _10 { get; set; }
        public _111 _11 { get; set; }
        public _121 _12 { get; set; }
        public _131 _13 { get; set; }
        public _141 _14 { get; set; }
        public _151 _15 { get; set; }
        public Most_Common1 most_common { get; set; }
    }

    public class _01
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _16
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _2
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _5
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _101
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _111
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _121
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _131
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _141
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _151
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common1
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _677
    {
        public AT2 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS2 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE2 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD2 WD { get; set; }
    }

    public class AT2
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS2
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE2
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD2
    {
        public _02 _0 { get; set; }
        public _17 _1 { get; set; }
        public _21 _2 { get; set; }
        public _51 _5 { get; set; }
        public _102 _10 { get; set; }
        public _112 _11 { get; set; }
        public _122 _12 { get; set; }
        public _132 _13 { get; set; }
        public _142 _14 { get; set; }
        public _152 _15 { get; set; }
        public Most_Common2 most_common { get; set; }
    }

    public class _02
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _17
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _21
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _51
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _102
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _112
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _122
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _132
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _142
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _152
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common2
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _678
    {
        public AT3 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS3 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE3 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD3 WD { get; set; }
    }

    public class AT3
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS3
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE3
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD3
    {
        public _03 _0 { get; set; }
        public _18 _1 { get; set; }
        public _22 _2 { get; set; }
        public _3 _3 { get; set; }
        public _52 _5 { get; set; }
        public _6 _6 { get; set; }
        public _7 _7 { get; set; }
        public _8 _8 { get; set; }
        public _91 _9 { get; set; }
        public _103 _10 { get; set; }
        public _113 _11 { get; set; }
        public _123 _12 { get; set; }
        public _133 _13 { get; set; }
        public _143 _14 { get; set; }
        public _153 _15 { get; set; }
        public Most_Common3 most_common { get; set; }
    }

    public class _03
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _18
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _22
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _3
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _52
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _6
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _7
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _8
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _91
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _103
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _113
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _123
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _133
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _143
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _153
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common3
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _679
    {
        public AT4 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS4 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE4 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD4 WD { get; set; }
    }

    public class AT4
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS4
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE4
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD4
    {
        public _04 _0 { get; set; }
        public _19 _1 { get; set; }
        public _23 _2 { get; set; }
        public _31 _3 { get; set; }
        public _53 _5 { get; set; }
        public _61 _6 { get; set; }
        public _71 _7 { get; set; }
        public _81 _8 { get; set; }
        public _92 _9 { get; set; }
        public _104 _10 { get; set; }
        public _114 _11 { get; set; }
        public _124 _12 { get; set; }
        public _134 _13 { get; set; }
        public _144 _14 { get; set; }
        public _154 _15 { get; set; }
        public Most_Common4 most_common { get; set; }
    }

    public class _04
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _19
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _23
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _31
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _53
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _61
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _71
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _81
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _92
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _104
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _114
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _124
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _134
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _144
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _154
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common4
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _680
    {
        public AT5 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS5 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE5 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD5 WD { get; set; }
    }

    public class AT5
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS5
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE5
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD5
    {
        public _05 _0 { get; set; }
        public _110 _1 { get; set; }
        public _54 _5 { get; set; }
        public _62 _6 { get; set; }
        public _72 _7 { get; set; }
        public _82 _8 { get; set; }
        public _93 _9 { get; set; }
        public _105 _10 { get; set; }
        public _115 _11 { get; set; }
        public _125 _12 { get; set; }
        public _135 _13 { get; set; }
        public _145 _14 { get; set; }
        public _155 _15 { get; set; }
        public Most_Common5 most_common { get; set; }
    }

    public class _05
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _110
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _54
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _62
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _72
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _82
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _93
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _105
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _115
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _125
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _135
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _145
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _155
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common5
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _681
    {
        public AT6 AT { get; set; }
        public DateTime First_UTC { get; set; }
        public HWS6 HWS { get; set; }
        public DateTime Last_UTC { get; set; }
        public int Month_ordinal { get; set; }
        public string Northern_season { get; set; }
        public PRE6 PRE { get; set; }
        public string Season { get; set; }
        public string Southern_season { get; set; }
        public WD6 WD { get; set; }
    }

    public class AT6
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class HWS6
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class PRE6
    {
        public float av { get; set; }
        public int ct { get; set; }
        public float mn { get; set; }
        public float mx { get; set; }
    }

    public class WD6
    {
        public _06 _0 { get; set; }
        public _116 _1 { get; set; }
        public _24 _2 { get; set; }
        public _32 _3 { get; set; }
        public _55 _5 { get; set; }
        public _63 _6 { get; set; }
        public _73 _7 { get; set; }
        public _83 _8 { get; set; }
        public _94 _9 { get; set; }
        public _106 _10 { get; set; }
        public _117 _11 { get; set; }
        public _126 _12 { get; set; }
        public _136 _13 { get; set; }
        public _146 _14 { get; set; }
        public _156 _15 { get; set; }
        public Most_Common6 most_common { get; set; }
    }

    public class _06
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _116
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _24
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _32
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _55
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _63
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _73
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _83
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _94
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _106
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _117
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _126
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public int compass_right { get; set; }
        public int compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _136
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _146
    {
        public int compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class _156
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Most_Common6
    {
        public float compass_degrees { get; set; }
        public string compass_point { get; set; }
        public float compass_right { get; set; }
        public float compass_up { get; set; }
        public int ct { get; set; }
    }

    public class Validity_Checks
    {
        public _674 _674 { get; set; }
        public _6751 _675 { get; set; }
        public _6761 _676 { get; set; }
        public _6771 _677 { get; set; }
        public _6781 _678 { get; set; }
        public _6791 _679 { get; set; }
        public _6801 _680 { get; set; }
        public _6811 _681 { get; set; }
        public _682 _682 { get; set; }
        public int sol_hours_required { get; set; }
        public string[] sols_checked { get; set; }
    }

    public class _674
    {
        public AT7 AT { get; set; }
        public HWS7 HWS { get; set; }
        public PRE7 PRE { get; set; }
        public WD7 WD { get; set; }
    }

    public class AT7
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS7
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE7
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD7
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6751
    {
        public AT8 AT { get; set; }
        public HWS8 HWS { get; set; }
        public PRE8 PRE { get; set; }
        public WD8 WD { get; set; }
    }

    public class AT8
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS8
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE8
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD8
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6761
    {
        public AT9 AT { get; set; }
        public HWS9 HWS { get; set; }
        public PRE9 PRE { get; set; }
        public WD9 WD { get; set; }
    }

    public class AT9
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS9
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE9
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD9
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6771
    {
        public AT10 AT { get; set; }
        public HWS10 HWS { get; set; }
        public PRE10 PRE { get; set; }
        public WD10 WD { get; set; }
    }

    public class AT10
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS10
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE10
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD10
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6781
    {
        public AT11 AT { get; set; }
        public HWS11 HWS { get; set; }
        public PRE11 PRE { get; set; }
        public WD11 WD { get; set; }
    }

    public class AT11
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS11
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE11
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD11
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6791
    {
        public AT12 AT { get; set; }
        public HWS12 HWS { get; set; }
        public PRE12 PRE { get; set; }
        public WD12 WD { get; set; }
    }

    public class AT12
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS12
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE12
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD12
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6801
    {
        public AT13 AT { get; set; }
        public HWS13 HWS { get; set; }
        public PRE13 PRE { get; set; }
        public WD13 WD { get; set; }
    }

    public class AT13
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS13
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE13
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD13
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _6811
    {
        public AT14 AT { get; set; }
        public HWS14 HWS { get; set; }
        public PRE14 PRE { get; set; }
        public WD14 WD { get; set; }
    }

    public class AT14
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS14
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE14
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD14
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class _682
    {
        public AT15 AT { get; set; }
        public HWS15 HWS { get; set; }
        public PRE15 PRE { get; set; }
        public WD15 WD { get; set; }
    }

    public class AT15
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class HWS15
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class PRE15
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

    public class WD15
    {
        public int[] sol_hours_with_data { get; set; }
        public bool valid { get; set; }
    }

}


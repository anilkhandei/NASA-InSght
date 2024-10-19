using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASA_InSight.Data
{
    [Table("APICallLogs")]
    public class APICallLogs
    {
        [Key]
        public int Id { get; set; }

        [Column("api_data")]
        public string APIData { get; set; }

        [Column("api_url")]
        public string APIURL { get; set; }

        [Column("api_capture_ts")]
        public DateTime TimeStamp { get; set; }

    }
}

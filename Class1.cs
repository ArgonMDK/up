using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UP53
{
    [Table(Name = "ClientService")]
    class ClientServ
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int Id { get; set; }
        [Column(Name = "ClientID")]
        public int ClientID { get; set; }
        [Column(Name = "ServiceID")]
        public int ServiceID { get; set; }
        [Column(Name = "StartTime")]
        public DateTime StartTime { get; set; }
        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }
}

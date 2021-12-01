using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UP53
{
    [Table(Name = "Service")]
    class Serv
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int Id { get; set; }
        [Column(Name = "Title")]
        public string Title { get; set; }
        [Column(Name = "Cost")]
        public decimal Cost { get; set; }
        [Column(Name = "DurationInSeconds")]
        public int DurationInSeconds { get; set; }
        [Column(Name = "Description")]
        public string Description { get; set; }
        [Column(Name = "Discount")]
        public decimal Discount { get; set; }
        [Column(Name = "MainImagePath")]
        public string MainImagePath { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public class Address
    {
        [PrimaryKey, AutoIncrement]
        public int Address_ID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}

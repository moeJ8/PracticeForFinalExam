using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public class Bills
    {
        [PrimaryKey, AutoIncrement]
        public int Bill_ID { get; set; }
        public int Address_ID { get; set; }
        public int Card_ID { get; set; }
        public string Processor { get; set; }
        public string RTX { get; set; }
        public string Memory_Size { get; set; }
        public string Ram_Size { get; set; }
        public int Total { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public class Card
    {
        [PrimaryKey, AutoIncrement]
        public int Card_ID { get; set; }
        public string Card_Name { get; set; }
        public string Card_Number { get; set; }
    }
}

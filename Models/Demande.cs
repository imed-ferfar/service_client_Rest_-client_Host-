using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2_Host_Rest.Models
{
    public class Demande
    {
        public string Host { get; set; }
        public string User { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Time { get; set; }
        public int Year { get; set; }
        public string Message { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagMemberAPI.Data
{
    public class Warning
    {
        public int ID { get; set; }
        public string WarningDescription { get; set; }
        public DateTime DateIssued { get; set; }

    }
}

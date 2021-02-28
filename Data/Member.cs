using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace TagMemberAPI.Data
{
    public class Member
    {              
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime DateJoined { get; set; }
        public bool BCTDone { get; set; }
        public List<Warning> Warnings { get; set; }
    }
}

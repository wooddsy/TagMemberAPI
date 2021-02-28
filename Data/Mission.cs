using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace TagMemberAPI.Data
{
    public class Mission
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Member> Members { get; set; }
        public DateTime DateOfOP { get; set; }



    }
}

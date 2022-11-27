using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayzServer
{

    public class DayzServerData
    {
        public string dayzDirectory { get; set; }
        public string modsDirectory { get; set; }
        public string launchParams { get; set; }
        public List<String> modlist { get; set; }
    }

}

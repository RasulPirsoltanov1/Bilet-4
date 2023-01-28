using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_4.Core.Entities
{
    public class Setting
    {
        public int? Id { get; set; }
        public string?  SiteName { get; set; }
        public string?  CallCenter { get; set; }
        public string?  Location { get; set; }
        public string?  Logo { get; set; }
        public string?  Icon { get; set; }
    }
}

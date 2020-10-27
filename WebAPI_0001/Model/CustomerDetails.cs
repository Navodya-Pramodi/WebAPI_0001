using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_0001.Model
{
    public class CustomerDetails
    {
        public long Id { get; set; }
        public long Old { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

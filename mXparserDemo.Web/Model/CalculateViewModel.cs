using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mXparserDemo.Web.Model
{
    public class CalculateViewModel
    {
        public string Formula { get; set; }
        public Parameter para { get; set; }
    }

    public class Parameter
    {
        public double a { get; set; }
        public double b { get; set; }
    }

}

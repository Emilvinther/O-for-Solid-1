using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_for_Solid
{
    public class Filter
    {
        public Filter() 
        {

        }

        public string ApplyNewFilter()
        {
            return $"New Filter have been applied";
        }

        public string RemoveOldFilter()
        {
            return $"Remove old filter";
        }
    }
}

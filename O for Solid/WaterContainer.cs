using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_for_Solid
{
    public class WaterContainer
    {
        public int currentLevel;
        public int maxLevel = 100;



        public WaterContainer(int current) 
        {
            this.currentLevel = current;
        }


        public string FillUpWaterContainer(int current)
        {
            if (current < maxLevel)
            {
                return $"Water is missing, container will be filled";

            }

            else
            {
                return $"Water Container is already full";
            }
        }
    }
}

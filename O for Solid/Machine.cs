using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_for_Solid
{
    public abstract class Machine
    {
        protected bool turnedOn;


        public Machine()
        {
            turnedOn = false;
        }



        public virtual string TurnOff()
        {
            if (turnedOn == true)
            {
                return $"{GetType().Name} have been turned off";
            }

            else
            {
                return $"{GetType().Name} is already off";
            }

           

        } 

        public virtual string TurnOn()
        {
            if (turnedOn == false)
            {
                turnedOn = true;
                return $"{GetType().Name} have been turned On";
            }

            else
            {
                return $"{GetType().Name} is already on";
            }
        }

    }
}

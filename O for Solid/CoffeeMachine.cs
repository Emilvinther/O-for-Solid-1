using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_for_Solid
{
    public class CoffeeMachine : Machine
    {
        static Random random = new Random();
        static int ran = random.Next(60, 101);
        static int rand = random.Next(1, 100);



        

        WaterContainer wc = new(ran);
        Filter filter = new();
        Drink drink = new Drink(rand);    





        public CoffeeMachine()
        {
           
        }

        

        public string Brewing(string type)
        {
            return
            $"{filter.RemoveOldFilter()}\n" +
            $"{filter.ApplyNewFilter()}\n" +
            $"{drink.amount}g {type} have been added to the filter \n" +
            $"{wc.FillUpWaterContainer(ran)}\n" +
            $"{wc.maxLevel - wc.currentLevel} ml water have been added\n" +
            $"{TurnOn()}\n" +
            $"{GetType().Name} is brewing\n" +
            $"{TurnOff()}";
        }
    } 
}

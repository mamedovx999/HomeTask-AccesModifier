using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_AccesModifier
{
    internal class ChinaCity : City
    {

        public ChinaCity()
        {
            
        }
        public void CountPopulation(int population)
        {
            if (population < 10000000)
            {
                Console.WriteLine("1 milyondan kicik ola bilmez");
                return;
            }
            else
            {
                Console.WriteLine($"Ehali {population}");
            }
        }


        //private int _population;



        //public int Population
        //{
        //    get
        //    {
        //        return _population;
        //    }
        //    set
        //    {
        //        if (value < 10000000)
        //        {
        //            Console.WriteLine("1000000 kicik ola bilmez");
        //            return;
        //        }
        //        _population = value;
        //    }
        //}

        //public ChinaCity(string name, int population) : base(name, population)
        //{
        //    _population = population;
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_AccesModifier
{
    internal class City
    {
        private string _name;
        private int _population;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( value.Length<3 || value.Length>20) 
                {
                    Console.WriteLine("duzgun daxil et");
                    return;
                }
                if (!IsAllLetter(value))
                {
                    Console.Write("Yalniz Herfler olar");
                    return;
                }
                _name = value;
            }
        }
        public int Population
        {
            get
            {
                return _population;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("0 dan kicik ola bilmez");
                    return;
                }
                _population = value;
            }
        }
     
        private bool IsAllLetter(string value)
        {
            foreach (char c in value)
            {
                if(!char.IsLetter (c))
                    return false;
            }
            return true;
        }
        public City()
        {
            
        }
        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }
    }
}

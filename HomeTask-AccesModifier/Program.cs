namespace HomeTask_AccesModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ///  City city = new City("China",23);
          //  ChinaCity china = new ChinaCity ();
         //  china.Population = 1000000000;
           // china.CountPopulation(china.Population);

            ChinaCity[] chinaCities = new ChinaCity[]
            {
                new ChinaCity {Name="Pekin",Population=5000000},
                new ChinaCity {Name="HonKong",Population=7000000},
                new ChinaCity {Name="Beijing",Population=8000000},
                new ChinaCity {Name="Wuhan",Population=9000000},

            };

            CalculatePop(chinaCities);

            static void CalculatePop(ChinaCity[] chinaCities)
            {
                int avarage = 0;
                int sum = 0;
                foreach (ChinaCity item in chinaCities)
                {
                    sum += item.Population;
                    avarage = sum / chinaCities.Length;
                   
                }
                Console.WriteLine(avarage);

            }

            






        }
    }
}

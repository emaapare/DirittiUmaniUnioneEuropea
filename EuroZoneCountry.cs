using Polimorfismo.Interfaces;
using System;

namespace Polimorfismo
{

    public class EuroZoneCountry : EUCountry, IEuroZone
    {
        // ONU Contracts
        // EURO Contracts
        // EU Contracts 

        public static int _totalPopulation;

        public void UploadPopolation(int Population)
        {
            _totalPopulation += Population;
        }

        public EuroZoneCountry(string Name, string State, string Government, string Constitution, int Population)
            : base(Name, State, Government, Constitution, Population)
        {
            UploadPopolation(Population);
            Console.WriteLine($"the total population of the eurozone is: {_totalPopulation}");
        }


        public void Euro()
        {
            //Contratto EURO ZONA 
        }

    }



}


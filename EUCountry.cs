using Polimorfismo.Interfaces;
using System;
using System.Linq;

namespace Polimorfismo
{
    public class EUCountry : ONUCountry, IEuropeanUnion
    {
        // UE Contracts
        public void HumanRights() { }
        public void ConstitutionIntegration()
        {
            Constitution += "EU Costitution";
            Console.WriteLine($"{Name} -  {Constitution}");
        }

        public void ResidencyPermit()
        {
            Console.WriteLine($"{Name} has required a residency permit");
        }

        public EUCountry(string Name, string State, string Government, string Constitution, int Population) :
            base(Name, State, Government, Constitution, Population)
        {
            ConstitutionIntegration();
        }




        // ONU Contracts
        public virtual void PopulationControl()
        {


            Console.WriteLine("Polizia di Frontiera");
            Console.WriteLine("--------------------------------");

        }
        public virtual void TerritoryControl()
        {

            Console.WriteLine("ARMY");
            Console.WriteLine("--------------------------------");

        }

    }

}


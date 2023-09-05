using System;



namespace Polimorfismo.Interfaces
{
    class CapitalPunishmentCountry : Country, IONU, ICapitalPunishment
    {
        public CapitalPunishmentCountry(string Name, string State, string Government, string Constitution, int Population) :
            base(Name, State, Government, Constitution, Population)
        {

        }
        public void Death()
        {
            Console.WriteLine("Apply death Punishment");
        }

        public virtual void PopulationControl()
        {
            Console.WriteLine("");

        }

        public void TerritoryControl()
        {
            Console.WriteLine("");

        }
    }


}


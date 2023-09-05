using System;
using Polimorfismo.Interfaces;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // NOTA: Se si necessita di specifici overriding dei metodi, è necessario avere una classe per ogni paese specifico.
            // In questo caso stiamo solo classificano i paesi per categoria 


            // upcasting 
            IONU USA = new CapitalPunishmentCountry("USA", "democratico", "Federale", "1789", 6990);
            IONU Spagna = new EuroZoneCountry("spagna", "democratico", "Parlamentare", "1922", 63333);
            IONU Argentina = new ONUCountry("Argentina", "democratico", "Parlamentare", "1922", 104000);

            IEuropeanUnion italy = new EUCountry("italy", "democratico", "parlamentare", "1947", 60000000);
            italy.ResidencyPermit();

            EUCountry EuroItaly = (EUCountry)  italy; // Downcasting


            EuroCentralBank.CalcSpread(EuroItaly);
            StrasbourgCourt.HumanRightsInvestigation(USA);
            StrasbourgCourt.HumanRightsInvestigation(italy);
            StrasbourgCourt.HumanRightsInvestigation(Argentina);


        }


    }
}


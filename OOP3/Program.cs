using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager();            
            ICreditManager vehicleCreditManager = new VehicleCreditManager();            
            ICreditManager dwellingCreditManager = new DwellingCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Apply(dwellingCreditManager);//(a type of ICreditManager)



            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager };
            applicationManager.ProvideCreditInformation(credits);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager)//Credit type independent
        {
            //Applicant info evaluation
            //
            creditManager.Calculate();
        }

        public void ProvideCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

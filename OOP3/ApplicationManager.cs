using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)//Credit type independent
        {
            //Applicant info evaluation
            //
            creditManager.Calculate();
            loggerService.Log();
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

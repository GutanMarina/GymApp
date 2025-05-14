using System;
using eGym.BusinessLogic.BlStruct;
using eGym.BusinessLogic.Interfaces;
using eGym.BusinessLogic.BlStruct;
using eGym.BusinessLogic.Interfaces;

namespace eGym.BusinessLogic
{//implimentarea la metoda
    public class BusinessLogic
    {
        public ISession GetAuthBl()
        {
            return new LoginBl();
        }

    }
}
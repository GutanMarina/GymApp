using System;
using System.Collections.Generic;
using System.Text;
using eGym.Domain.Entities.User;
using eGym.Domain.Model.User;

namespace eGym.BusinessLogic.Interfaces
{//declaram metoda
    public interface ISession
    {
        void UserRegister(UDbTable data);
    }
}



using System;
using System.Collections.Generic;
using System.Text;
using eGym.BusinessLogic.Core;
using eGym.BusinessLogic.Interfaces;
using eGym.Domain.Entities.User;
using eGym.Domain.Model.User;

namespace eGym.BusinessLogic.BlStruct
{//legatura businesslog cu metoda, declararea metodei, implementare din interfata cu parametru in useriapi
    public class LoginBl : UserAPI, ISession
    {

        public string UserAuthLogic(UserLoginDTO data)
        {
            return UserAuthLogicAction(data);
        }


        public void UserRegister(UDbTable data)
        {
            throw new NotImplementedException();
        }
    }
}

using eGym.BusinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eGym.BusinessLogic.Interfaces;
using eGym.Domain.Entities.User;
using eGym.Domain.Model.User;
using System.Data.Entity;
using System.Web;
using eGym.BusinessLogic.DBModel;
using eGym.Domain.Entities;


namespace eGym.BusinessLogic.BlStruct
{
    public class SessionBL : UserAPI, ISession
    {
        public void UserRegister(UDbTable data)
        {
            UserRegisterAction(data);
        }

    }

}

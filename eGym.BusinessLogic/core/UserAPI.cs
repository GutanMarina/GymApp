using System;
using System.Collections.Generic;
using System.Text;
using eGym.BusinessLogic.DBModel;
using eGym.Domain.Entities.User;
using eGym.Domain.Model.User;
using System.Linq;
using System.Data.Entity;
namespace eGym.BusinessLogic.Core
{//implementarea metodei
    public class UserAPI
    {
        public string UserAuthLogicAction(UserLoginDTO data)
        {
            return "token key";
        }
        public void UserRegisterAction(UDbTable data)
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.UDbTable.Any(u => u.Email == data.Email || u.Username == data.Username))
                {
                    throw new Exception("Acest utilizator există deja!");
                }

                db.UDbTable.Add(data);
                db.SaveChanges();
            }
        }
    }
}


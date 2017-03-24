using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log.Models;

namespace log.Service
{
    public class LogDbService
    {
        public logEntities1 db = new logEntities1();
        int x=0;
        //注册用户
        public void AddUser(string strUsername, string strPassword)
        {
            user newUser = new user();
            newUser.username = strUsername;
            newUser.password = strPassword;
            db.user.Add(newUser);
            db.SaveChanges();
        }
        public int ConfirmUser(string username,string password)
        {
            //db.user.Where(a => a.username == username && a.password == password).FirstOrDefault();
            foreach (user item in db.user)
            {
                if(item.username.Trim()==username&&item.password.Trim()==password)
                {
                    x = 1;
                    break;
                }
            }
            return (x);
            
        }
    }
}
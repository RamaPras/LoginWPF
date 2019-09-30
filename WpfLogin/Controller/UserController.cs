using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLogin.Context;
using WpfLogin.Models;

namespace WpfLogin.Controller
{
    public class UserController
    {
        public static void AddUser()
        {
            using (var ObjContext = new MyContext())
            {
                var User = new User
                {
                  
                };
                ObjContext.Users.Add(User);
                ObjContext.SaveChanges();
            }
        }
    }
}

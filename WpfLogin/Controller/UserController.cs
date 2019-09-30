using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfLogin.Context;
using WpfLogin.Models;

namespace WpfLogin.Controller
{
    public class UserController
    {
        public void AddUser(string uname, string pword)
        {
            var result = 0;
            User user = new User();
            MyContext ObjContext = new MyContext();

            user.Username = uname;
            user.Password = pword;
            ObjContext.Users.Add(user);
            result = ObjContext.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Successful");
            }
            else
            {
                MessageBox.Show("Register Failed");
            }

    
        }

        public void UserLogin(string uname, string pword)
        {
            var result = 0;
            User user = new User();
            MyContext ObjContext = new MyContext();
            var get = ObjContext.Users.Where(U => U.Username == uname).FirstOrDefault<User>();
            if(get == null)
            {
                MessageBox.Show("Your Username is Incorrect");
            }
            else
            {
                if(get.Password != pword)
                {
                    get.Password = pword;
                    result = ObjContext.SaveChanges();

                    if(result > 0)
                    {
                        MessageBox.Show("Update Success");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Your Password can't be the same!");
                }
            }
        }

     
    }
}

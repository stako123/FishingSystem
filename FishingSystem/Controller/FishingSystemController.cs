using FishingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingSystem.Controller
{
    internal class FishingSystemController
    {
        public string Login(string name, string pass)
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                var Login = fish.Logins.Where(s => s.name == name).FirstOrDefault();
                if (Login != null)
                {
                    if(Login.name == name && Login.password == pass)
                    {
                        return null;
                    }
                    else
                    {
                        return "The Username or password is incorrect, please try again";
                    }
                }

                else
                {
                    return "No such user!";
                }

            }
            
        }
    }
}

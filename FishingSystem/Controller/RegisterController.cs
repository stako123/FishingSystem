using FishingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingSystem.Controller
{
    internal class RegisterController
    {
        public void RegisterCreate(Login acc)
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                var id = fish.Logins.ToList().LastOrDefault();
                if (id == null)
                {
                    id = new Login();
                    id.Id = 0;
                }
                acc.Id = id.Id + 1;
                acc.ShipID = 1; //placeholder!
                fish.Logins.Add(acc);
                fish.SaveChanges();
            }
        }
    }
}

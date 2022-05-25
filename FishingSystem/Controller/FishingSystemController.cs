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

        public List<Catch> GetAll()
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                var catches = fish.Catches.ToList();
                return catches;
            }
        }

        public void CreateCatch(Catch a)
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                if (fish.Catches.ToList().LastOrDefault() == null)
                {
                    a.CatchID = 1;
                }
                else
                {
                    a.CatchID = fish.Catches.ToList().LastOrDefault().CatchID + 1;
                }
                fish.Catches.Add(a);
                fish.SaveChanges();
            }
        }

        public void DeleteCatch(int id)
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                var catchToDelete = fish.Catches.Where(a => a.CatchID == id).FirstOrDefault();
                if (catchToDelete != null)
                {
                    fish.Catches.Remove(catchToDelete);
                    fish.SaveChanges();
                }
            }
        }

        public void UpdateCatch(int id, Catch catchtoupdate)
        {
            using (FishingDBEntities fish = new FishingDBEntities())
            {
                var catchToUpdate = fish.Catches.Where(g => g.CatchID == id).FirstOrDefault();
                if (catchToUpdate != null)
                {
                    catchToUpdate.CatchID = id;
                    catchToUpdate.AmountOfCatch = catchtoupdate.AmountOfCatch;
                    catchToUpdate.TripLenght = catchtoupdate.TripLenght;
                    catchToUpdate.TripStartDate = catchtoupdate.TripStartDate;
                    fish.SaveChanges();
                }
            }
        }
    }
}

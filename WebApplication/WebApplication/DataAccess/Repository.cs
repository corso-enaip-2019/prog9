using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public class Repository
    {
        static Repository()
        {
            Instance = new Repository();
        }

        public static Repository Instance { get; }

        private Repository()
{ 
            _superhero = new List<Superhero>
            {
                new Superhero{
                    Id = 1,
                    SecretName = "Clark Kent",
                    HeroName = "Superman",
                    Strenght = 1000,
                    AssetsValue = 5_000,
                    CanFly = true,
                    Powers = "All"
                },
                new Superhero{
                    Id = 2,
                    SecretName = "Bruce Waine",
                    HeroName = "Batman",
                    Strenght = 10,
                    AssetsValue = 1_000_000,
                    CanFly = false,
                    Powers = "none"
                },
                new Superhero{
                    Id = 3,
                    SecretName = "Diana qualcosa",
                    HeroName = "Wonderwoman",
                    Strenght = 500,
                    AssetsValue = 100_000,
                    CanFly = true,
                    Powers = "truth string"
                }
            };
        }

        public int InsertSuperHero(Superhero model)
        {
            var maxId = _superhero.Count == 0
                ?0
                :_superhero.Max(x => x.Id);

            model.Id = maxId + 1;

            _superhero.Add(model);

            return model.Id;
        }

        private List<Superhero> _superhero;

        public List<Superhero> GetAll()
        {
            return _superhero.ToList();
        }

        public bool UpdateSuperhero(Superhero model)
        {
            //var old = _superhero.FirstOrDefault(x => x.Id == model.Id);
            //var indexOfOld = _superhero.IndexOf(old);

            var index = _superhero.FindIndex(x => x.Id == model.Id);

            _superhero[index] = model;

            return true;
        }

        public Superhero Get(int id)
        {
            return _superhero.FirstOrDefault(x => x.Id == id);
        }

        public bool Remove(int id)
        {
            var toRemove = _superhero.FirstOrDefault(x => x.Id == id);

            if (toRemove != null)
            {
                _superhero.Remove(toRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVillain.Infrastructures;
using WebApplicationVillain.Models;

namespace WebApplicationVillain.DataAccess
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
            _superheroes = new List<Superhero>
            {
                new Superhero
                {
                    Id = 1,
                    HeroName = "Superman",
                    SecretName = "Clark Kent",
                    CanFly = true,
                    AssetsValue = 5_000,
                    Strength = 100,
                    Powers = "Super laser sight, super speed"
                },
                new Superhero
                {
                    Id = 2,
                    HeroName = "Batman",
                    SecretName = "Bruce Wayne",
                    CanFly = false,
                    AssetsValue = 500_000_000,
                    Strength = 9,
                    Powers = "",
                },
                new Superhero
                {
                    Id = 3,
                    HeroName = "Wonder Woman",
                    SecretName = "Diana Qualcosa",
                    CanFly = false,
                    AssetsValue = 1_000_000,
                    Strength = 70,
                    Powers = "Truth string"
                }
            };

            _villains = new List<Villain>
            {
                new Villain
                {
                    Id = 1,
                    SecretName = "Joker",
                    Characteristics = "psychopath",
                    FirstData =  new DateTime(1940,03,20),
                    KilledPeople = 350,
                    KidnappedPeople = 20,
                    Strength = 5
                },
                new Villain
                {
                    Id = 2,
                    SecretName = "Goblin",
                    Characteristics = "ruthless",
                    FirstData = new DateTime(1964,05,08),
                    KilledPeople = 270,
                    KidnappedPeople = 35,
                    Strength = 8
                },
                new Villain
                {
                    Id = 3,
                    SecretName = "Thanos",
                    Characteristics = "Insane Titan",
                    FirstData = new DateTime(1900,01,01),
                    KilledPeople = 300_000,
                    KidnappedPeople = 0,
                    Strength = 1000
                }
            };
        }

        public int InsertSuperhero(Superhero model)
        {
            if (model == null)
                throw new InvalidInputException("null input");

            if (model.Id != 0)
                throw new InvalidInputException("non-zero id");

            var maxId = _superheroes.Count == 0
                ? 0
                : _superheroes.Max(x => x.Id);

            model.Id = maxId + 1;

            _superheroes.Add(model);

            return model.Id;
        }

        public void UpdateSuperhero(int id, Superhero model)
        {
            if (model == null)
                throw new InvalidInputException("null input");

            if (model.Id == 0 || id != model.Id)
                throw new InvalidInputException("invalid id");

            // more verbose:
            //var old = _superheroes.FirstOrDefault(x => x.Id == model.Id);
            //var indexOfOld = _superheroes.IndexOf(old);

            // more concise:
            var index = _superheroes.FindIndex(x => x.Id == model.Id);

            if (index == -1)
                throw new NotFoundException("superhero not found");

            _superheroes[index] = model;
        }

        public List<Superhero> _superheroes;

        public List<Superhero> GetAllSuperheroes()
        {
            return _superheroes.ToList();
        }

        public Superhero GetSuperhero(int id)
        {
            var model = _superheroes.FirstOrDefault(x => x.Id == id);

            if (model == null)
                throw new NotFoundException("superhero not found");

            return model;
        }

        public void RemoveSuperhero(int id)
        {
            var toRemove = _superheroes.FirstOrDefault(x => x.Id == id);

            if (toRemove == null)
                throw new NotFoundException("superhero not found");

            _superheroes.Remove(toRemove);
        }

        public List<Villain> _villains;

        public int InsertVillain(Villain model)
        {
            if (model == null)
            {
                throw new InvalidInputException("null input");
            }
            if (model.Id == 0)
            {
                throw new InvalidInputException("non zero id");
            }

            var maxId = _villains.Count == 0
                ? 0
                : _villains.Max(x => x.Id);

            model.Id = maxId + 1;

            _villains.Add(model);

            return model.Id;
        }

        public void UpdateSuperhero(int id, Villain model)
        {
            if (model == null)
                throw new InvalidInputException("null input");

            if (model.Id == 0 || id != model.Id)
                throw new InvalidInputException("invalid id");


            var index = _villains.FindIndex(x => x.Id == model.Id);

            if (index == -1)
                throw new NotFoundException("villain not found");

            _villains[index] = model;
        }

        public List<Villain> GetAllVillains()
        {
            return _villains.ToList();
        }

        public Villain GetVillain(int id)
        {
            var model = _villains.FirstOrDefault(x => x.Id == id);

            if (model == null)
            {
                throw new NotFoundException("villain not found");
            }
            return model;
        }

        public void RemoveVillain(int id)
        {
            var toRemove = _villains.FirstOrDefault(x => x.Id == id);

            if (toRemove == null)
            {
                throw new NotFoundException("villain not found");
            }

            _villains.Remove(toRemove);
        }
    }
}

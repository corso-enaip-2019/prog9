using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePizza
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    enum IngredientType
    {
        Pomodoro,
        Mozzarella,
        Ham,
        Mushrooms,
        RocketSalad

    }
    class Ingredient
    {
        public IngredientType Type { get; set; }
        public int Quantity { get; set; }
    }

    class Pizza
    {
        public List<Ingredient> Ingredients { get; }
        public bool IsMignon { get; set; }

        public Pizza(bool isMignon = false)
        {
            IsMignon = isMignon;
            Ingredients = new List<Ingredient>();

        }

    }
    interface IPizzaBuilder
    {
        Pizza Create();
    }

    class PizzaBuilder : IPizzaBuilder
    {

        private static Dictionary<bool, PizzaConfiguration> _configurations = new Dictionary<bool, PizzaConfiguration>
        {
            {
                false,
                new PizzaConfiguration
                {
                    Pomodoro = 25,
                    Mozzarella = 50,

                }
            },
            {
                true,
                new PizzaConfiguration
                {
                    Pomodoro = 15,
                    Mozzarella = 30,

                }
            },

        };

        private List<Ingredient> _ingredients;
        private PizzaConfiguration _configur;
        private bool _IsMignon { get; set; }

        public PizzaBuilder(bool isMignon = false)
        {
            _IsMignon = isMignon;
            _configur = _configurations[isMignon];
            _ingredients = new List<Ingredient>();
        }

        public PizzaBuilder AddPomodoro(bool isMignon)
        {
            _ingredients.Add(new Ingredient
            {
                Type = IngredientType.Pomodoro,
                Quantity = _configur.Pomodoro
            }
                );
            
            return this;
        }

        public PizzaBuilder AddMozzarella(bool _isMignon)
        {
            _ingredients.Add(new Ingredient
            {
                Type = IngredientType.Mozzarella,
                Quantity = _configur.Mozzarella
            }
                );

            return this;
        }

        public PizzaBuilder AddHam(bool isMignon)
        {
            _ingredients.Add(new Ingredient
            {
                Type = IngredientType.Ham,
                Quantity = _configur.Ham
            }
                );

            return this;
        }

        public PizzaBuilder AddMushrooms(bool isMignon)
        {
            _ingredients.Add(new Ingredient
            {
                Type = IngredientType.Mushrooms,
                Quantity = _configur.Mushrooms
            }
                );

            return this;
        }

        public PizzaBuilder AddRocketSalad(bool isMignon)
        {
            _ingredients.Add(new Ingredient
            {
                Type = IngredientType.RocketSalad,
                Quantity = _configur.RocketSalad
            }
                );

            return this;
        }

        public Pizza Create()
        {
            var ingredientClones = _ingredients
                .Select(y => new Ingredient { Type = y.Type, Quantity = y.Quantity });

            var p = new Pizza();
            p.Ingredients.AddRange(ingredientClones);
            return p;
            
        }

        private class PizzaConfiguration
        {
            public int Pomodoro { get; set; }
            public int Mozzarella { get; set; }
            public int Mushrooms { get; set; }
            public int Ham { get; set; }
            public int RocketSalad { get; set; }
        }
    }



}

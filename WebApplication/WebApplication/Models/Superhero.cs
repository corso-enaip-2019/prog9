using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Superhero
    {
        public int Id { get; set; }
        public string SecretName { get; set; }
        public string HeroName { get; set; }
        public int Strenght { get; set; }
        public double AssetsValue { get; set; }
        public bool CanFly { get; set; }
        public string Powers { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVillain.Models
{
    public class Superhero
    {
        public int Id { get; set; }

        [Required]
        public string SecretName { get; set; }

        [Required]
        public string HeroName { get; set; }

        [Range(1, int.MaxValue)]
        public int Strength { get; set; }

        public double AssetsValue { get; set; }

        public bool CanFly { get; set; }

        public string Powers { get; set; }

        public List< MyProperty { get; set; }
    }
}

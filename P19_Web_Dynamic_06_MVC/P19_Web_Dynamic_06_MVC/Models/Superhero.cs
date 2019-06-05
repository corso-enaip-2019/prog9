﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P19_Web_Dynamic_06_MVC.Models
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

        public List<Villain> Enemies { get; set; }
    }
}

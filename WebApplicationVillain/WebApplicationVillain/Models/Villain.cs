using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVillain.Infrastructures.Attributes;

namespace WebApplicationVillain.Models
{
    public class Villain
    {
        public int Id { get; set; }
        [Required]
        public string SecretName { get; set; }
       
        public string Characteristics { get; set; }

        [DataRange(1900,01,01)]
        public DateTime FirstData { get; set; }
        public int KilledPeople { get; set; }
        public int KidnappedPeople { get; set; }
        public int Strength { get; set; }
    }
}

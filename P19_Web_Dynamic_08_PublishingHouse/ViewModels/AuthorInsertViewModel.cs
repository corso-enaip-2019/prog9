using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P19_Web_Dynamic_08_PublishingHouse.ViewModels
{
    public class AuthorInsertViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}

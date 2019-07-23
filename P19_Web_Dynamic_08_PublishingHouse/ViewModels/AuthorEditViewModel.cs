using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P19_Web_Dynamic_08_PublishingHouse.ViewModels
{
    public class AuthorEditViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<int> BooksIds { get; set; }
    }
}

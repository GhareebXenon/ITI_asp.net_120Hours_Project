using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;

namespace GameStore.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
       public string Email { get; set; }
        public string Address { get; set; }

        [DisplayName("image")]
        [ValidateNever]
        public string? ImagePath { get; set; }
        [ValidateNever]
        public List<Game> Games { get; set; }
        
    }
}

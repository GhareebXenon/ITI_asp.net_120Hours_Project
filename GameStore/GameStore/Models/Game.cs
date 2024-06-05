using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "You Have To Provide A Valid Game Name")]
        [MaxLength(50, ErrorMessage = "Department name Can't be More than 50 Characters")]
        public string Name { get; set; }
        [DisplayName("About")]
        [Required(ErrorMessage = "You Have To Provide A Valid  Description")]
        [MinLength(10, ErrorMessage = "Description Can't be less than 10 Characters")]
        public string About { get; set; }
        [Required(ErrorMessage = "You Have To Provide A Valid Price!")]
        [Range(0.5, 120, ErrorMessage = "The Price Is InValid")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("image")]
        [ValidateNever]
        public string? ImagePath { get; set; }
        [DisplayName("Category")]
        [Range(1, int.MaxValue, ErrorMessage = "Choose A Valid Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [DisplayName("Developer")]
        [Range(1,int.MaxValue,ErrorMessage ="Choose A Valid Developer")]
        public int DeveloperId { get; set; }
        [ValidateNever]
        public Developer Developer { get; set; }

    }
}

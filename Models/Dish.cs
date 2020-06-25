using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int id {get; set;}

        [Required(ErrorMessage="Dish name is required")]
        [DisplayName("Dish")]
        public string Name {get; set;}

        [Required(ErrorMessage="Chef name is required")]
        [DisplayName("Chef")]
        public string Chef {get;set;}

        [Required(ErrorMessage="Tastiness is required")]
        [Range(1,5)]
        [DisplayName("Tastiness")]
        public int Tastiness {get; set;}

        [Required(ErrorMessage="Calories is required")]
        [Range(1, 5000)]
        [DisplayName("Calories")]
        public int Calories {get; set;}

        [Required(ErrorMessage="Description is required")]
        [DisplayName("Description")]
        public string Description {get;set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public Dish() {}


    }
}
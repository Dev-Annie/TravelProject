using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TravelProject.Models

{
    public class Rentals
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRentals { get; set; }

        //public int? Id { get; internal set; }


        [Display(Name = "Enter Rentals Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string? Rentalname { get; set; }

        [Display(Name = "Party")]
        [Range(1, 100)]
        public decimal? Party { get; set; }

        //[Display(Name = "Enter Description")]
        //[Required(ErrorMessage = "{0} is required.")]

        //public string? Description { get; set; }

        [Display(Name = "Enter Rental City")]
        [Required]
        [StringLength(30)]
        [RegularExpression("^[a-zA-Z-@.]*$", ErrorMessage = "Please type letters only")]
        public string? City { get; set; }

        [Display(Name = "Fee")]
        [DataType(DataType.Currency)]

        public decimal? Fee { get; set; }

        //[Display(Name = "Select the Image")]
        //public string? ImagePath { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public decimal? Party { get; set; }

        //[Display(Name = "Enter Description")]
        //[Required(ErrorMessage = "{0} is required.")]

        //public string? Description { get; set; }

        [Display(Name = "Enter Rental City")]
        public string? City { get; set; }

        [Display(Name = "Fee")]
        public decimal? Fee { get; set; }

        //[Display(Name = "Select the Image")]
        //public string? ImagePath { get; set; }


    }
}

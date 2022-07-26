﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelProject.Models

{
    public class Activities
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdActivity { get; set; }

        //public int? Id { get; internal set; }


        [Display(Name = "Enter Activity Name")]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z-@.]*$", ErrorMessage = "Please type letters only")]
        [Required(ErrorMessage = "{0} is required.")]
        public string? Title { get; set; }

        [Display(Name = "Duration")]
        public decimal? Duration { get; set; }

        //[Display(Name = "Enter Description")]
        //[Required(ErrorMessage = "{0} is required.")]

        //public string? Description { get; set; }

        [Display(Name = "Type")]
        public Groups Type { get; set; }
        //public string Type { get; set; }
      

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        //[Display(Name = "Select the Image")]
        //public string? ImagePath { get; set; }


    }

    public enum Groups
    {
        Sports,
        Attractions,
        Culture,
        Scenic
    }
}

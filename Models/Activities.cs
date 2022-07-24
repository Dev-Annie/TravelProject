using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelProject.Models

{
    public class Activities
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Enter Activity Code")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required.")] 
        public int idActivity { get; set; }

        [Display(Name = "Enter Activity Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required.")]
        public string? Title { get; set; }

        //[Display(Name = Duration)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "(0:m)"]
        //public DateTime Duration { get; set; }
        
        [Display(Name = "Enter Description")]
        [StringLength(200)]
        [Required(ErrorMessage = "{0} is required.")]
        public string? Description { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "(0:C)")]
        [Required(ErrorMessage = "{0} is required.")]
        public decimal Price { get; set; }
    
    }
}

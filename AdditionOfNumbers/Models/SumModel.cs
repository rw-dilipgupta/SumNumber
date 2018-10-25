using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdditionOfNumbers.Models
{
    /// <summary>
    /// Model for sum of number
    /// </summary>
    public class SumModel
    {
        [Display(Name = "First Number")]
        [Required(ErrorMessage = "First Number Is required")]
        public int FirstNumber { get; set; }  //for first Number

        [Display(Name = "Second Number")]
        [Required(ErrorMessage = "Second Number Is required")]
        public int SecondNumber { get; set; } //for Second Number

        public int Result { get; set; } //for storing result after addition

    }
}
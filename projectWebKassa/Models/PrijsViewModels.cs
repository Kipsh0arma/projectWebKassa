﻿using System.ComponentModel.DataAnnotations;

namespace projectWebKassa.Models
{
    public class PrijsViewModels
    {
    }

    /// <summary>
    /// create Prijs van de product = ProductId
    /// </summary>

    public class CreatePrijsViewModels
    {
        [Required]
        [Display(Name = "Prijs")]
        [DataType(DataType.Currency)]
        public string Prijs { get; set; }

        [Required]
        [Display(Name = "Naam")]
        [DataType(DataType.Text)]
        public string ProductId { get; set; }

        [Required]
        [Display(Name = "Start datum")]
        public string startDatum { get; set; }
    }

   
}
﻿namespace Vidly.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Numbers in Stock")]
        public byte NumberInStock { get; set; }
    }
}
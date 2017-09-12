namespace Vidly.Models
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

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Numbers in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Required]
        [Display(Name = "Availability")]
        public byte NumberAvailable { get; set; }
    }
}
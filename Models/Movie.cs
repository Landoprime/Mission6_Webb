namespace Mission6_LandonWebb.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    [Key]
    public int MovieId { get; set; }
    

    [ForeignKey("Category")]
    [Required]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    [Required(ErrorMessage = "Please select a category")]

    public string Title { get; set; }
    [Required(ErrorMessage = "Please enter the title of the movie")]

    public int Year { get; set; }
    //[Range(1888, 2024, ErrorMessage = "Please enter a valid year >= 1888")]

    public string? Director { get; set; }

    public string? Rating { get; set; }

    public bool Edited { get; set; }

    public string? LentTo { get; set; }

    public bool CopiedToPlex { get; set; }

    [StringLength(25, ErrorMessage = "Notes length must be between 0 and 25 characters.")]
    public string? Notes { get; set; }
}



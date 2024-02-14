namespace Mission6_LandonWebb.Models;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    public int MovieId { get; set; }

    public string Category { get; set; }

    public string Title { get; set; }

    public int Year { get; set; }

    public string Director { get; set; }

    public string Rating { get; set; }

    public bool? Edited { get; set; }

    public string? LentTo { get; set; }

    [StringLength(25, ErrorMessage = "Notes length must be between 0 and 25 characters.")]
    public string? Notes { get; set; }
}




using System.ComponentModel.DataAnnotations;

namespace GameX1.Model { }

public class PictureModel
{
    [Required(ErrorMessage = "Url is required!")]
    [StringLength(50, ErrorMessage = "Url cannot be longer than 50 characters!")]
    [Display(Name = "Url")]
    public string? Url { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace GameX1.Domain { }

public class Picture
{
    [Key]
    public long PictureId { get; set; }

    [ConcurrencyCheck]
    public string? Url { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public record CreateBannerDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Name { get; init; }

        [Required]
        [RegularExpression("^(top|left|right|center|bottom)$")]
        public string Position { get; init; }

        [Required]
        public string Text { get; init; }

        [RegularExpression("^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$")]
        public string? Color { get; init; }

        public string? Parameter { get; init; }
    }
}
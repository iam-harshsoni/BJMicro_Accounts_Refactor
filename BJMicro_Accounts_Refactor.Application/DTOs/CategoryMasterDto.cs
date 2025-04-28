
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record CategoryMasterDto
    (
        long CId,
        string? CName,
        string? Prefix
    );

    public record CreateCategoryDto(

        [Required(ErrorMessage = "FineGold is required.")] string? CName,
        [Required(ErrorMessage = "FineGold is required.")] string? Prefix
    );

    public record UpdateCategoryDto(
        long CId,
        [Required(ErrorMessage = "FineGold is required.")] string? CName,
        [Required(ErrorMessage = "FineGold is required.")] string? Prefix
    );
}

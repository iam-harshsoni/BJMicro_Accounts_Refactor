
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record CategoryMasterDto
(
    long CId,
    string? CName,
    string? Prefix,
    DateTime? CreatedDate,
    DateTime? UpdatedDate
);

public record CreateCategoryDto(

    [Required(ErrorMessage = "FineGold is required.")]
        string? CName,

    [Required(ErrorMessage = "FineGold is required.")]
        string? Prefix

);

public record UpdateCategoryDto(

    [Required(ErrorMessage = "FineGold is required.")]
        string? CName,

    [Required(ErrorMessage = "FineGold is required.")]
        string? Prefix
);


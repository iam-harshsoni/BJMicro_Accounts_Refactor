using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record AccGroupDto
    (
        long GroupId,
        long? Id,
        long? ParentId,
        string? GroupName,
        int? AffectsGross,
        DateTime? CreatedDate,
        DateTime? UpdateDate
    );

    public record CreateAccGroupDto
    (
        long? Id,
        long? ParentId,
        [Required(ErrorMessage = "Group Name is required.")] string? GroupName,
        [Required(ErrorMessage = "Affects Gross is required.")] int? AffectsGross
    );

    public record UpdateAccGroupDto
    (
        long GroupId,
        long? Id,
        long? ParentId,
        [Required(ErrorMessage = "Group Name is required.")] string? GroupName,
        [Required(ErrorMessage = "Affects Gross is required.")] int? AffectsGross
    );
}
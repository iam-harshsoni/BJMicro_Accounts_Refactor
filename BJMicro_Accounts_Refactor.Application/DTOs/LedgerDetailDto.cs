using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record LedgerDetailDto
    (
        long Id,
        long? LedgerId,
        string? Address,
        decimal? Contact,
        DateTime? CreatedDate,
        DateTime? UpdateDate
    );

    public record CreateLedgerDetailDto
      (
        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        string? Address,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Contact must be a non-negative number.")]
        decimal? Contact
      );

    public record UpdateLedgerDetailDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "Id must be greater than 0.")]
        long Id,

        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        string? Address,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Contact must be a non-negative number.")]
        decimal? Contact
    );

}
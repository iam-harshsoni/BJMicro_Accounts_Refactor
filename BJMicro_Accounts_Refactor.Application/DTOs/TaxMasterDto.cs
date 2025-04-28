using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record TaxMasterDto
    (
        long TId,
        string? VoucherType,
        long? VoucherId,
        decimal? TotalTax,
        DateTime? CDate,
        DateTime? UDate
    );

    public record CreateTaxMasterDto
    (
        [Required(ErrorMessage = "Voucher Type is required.")]
        [StringLength(50, ErrorMessage = "Voucher Type cannot exceed 50 characters.")]
        string? VoucherType,

        [Required(ErrorMessage = "Voucher Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Voucher Id must be greater than 0.")]
        long? VoucherId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Tax must be a non-negative number.")]
        decimal? TotalTax
    );

    public record UpdateTaxMasterDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "TId must be greater than 0.")]
        long TId,

        [Required(ErrorMessage = "Voucher Type is required.")]
        [StringLength(50, ErrorMessage = "Voucher Type cannot exceed 50 characters.")]
        string? VoucherType,

        [Required(ErrorMessage = "Voucher Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Voucher Id must be greater than 0.")]
        long? VoucherId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Tax must be a non-negative number.")]
        decimal? TotalTax
    );
}
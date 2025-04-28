using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record SalesMasterDto
    (
        long SId,
        string? BillNo,
        long? LedgerId,
        DateTime? Date,
        decimal? TotalWeight,
        string? Unit,
        decimal? TotalKarat,
        decimal? TotalMaking,
        decimal? TotalAmt,
        string? Remarks,
        DateTime? CreatedDate,
        DateTime? UpdateDate
    );

    public record CreateSalesMasterDto
    (
        [Required(ErrorMessage = "Bill No is required.")]
        [StringLength(100, ErrorMessage = "Bill No cannot exceed 100 characters.")]
        string BillNo,

        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        DateTime? Date,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Weight must be a non-negative number.")]
        decimal? TotalWeight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Karat must be a non-negative number.")]
        decimal? TotalKarat,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Making must be a non-negative number.")]
        decimal? TotalMaking,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Amount must be a non-negative number.")]
        decimal? TotalAmt,

        string? Remarks
    );

    public record UpdateSalesMasterDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "SId must be greater than 0.")]
        long SId,

        [Required(ErrorMessage = "Bill No is required.")]
        [StringLength(100, ErrorMessage = "Bill No cannot exceed 100 characters.")]
        string BillNo,

        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        DateTime? Date,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Weight must be a non-negative number.")]
        decimal? TotalWeight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Karat must be a non-negative number.")]
        decimal? TotalKarat,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Making must be a non-negative number.")]
        decimal? TotalMaking,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Total Amount must be a non-negative number.")]
        decimal? TotalAmt,

        string? Remarks
    );
}
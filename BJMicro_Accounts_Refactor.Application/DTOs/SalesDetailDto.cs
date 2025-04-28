using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record SalesDetailDto
    (
        long SDetailsId,
        long? SalesId,
        long? ProductId,
        decimal? Qty,
        decimal? Weight,
        string? Unit,
        decimal? Karat,
        decimal? KRate,
        decimal? Making,
        decimal? Rate,
        DateTime? CreatedDate,
        DateTime? UpdateDate
    );

    public record CreateSalesDetailDto
    (
        [Required(ErrorMessage = "Sales Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Sales Id must be greater than 0.")]
        long? SalesId,

        [Required(ErrorMessage = "Product Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Product Id must be greater than 0.")]
        long? ProductId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Qty must be a non-negative number.")]
        decimal? Qty,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative number.")]
        decimal? Weight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Karat must be a non-negative number.")]
        decimal? Karat,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "KRate must be a non-negative number.")]
        decimal? KRate,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Making must be a non-negative number.")]
        decimal? Making,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Rate must be a non-negative number.")]
        decimal? Rate
    );

    public record UpdateSalesDetailDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "SDetailsId must be greater than 0.")]
        long SDetailsId,

        [Required(ErrorMessage = "Sales Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Sales Id must be greater than 0.")]
        long? SalesId,

        [Required(ErrorMessage = "Product Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Product Id must be greater than 0.")]
        long? ProductId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Qty must be a non-negative number.")]
        decimal? Qty,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative number.")]
        decimal? Weight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Karat must be a non-negative number.")]
        decimal? Karat,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "KRate must be a non-negative number.")]
        decimal? KRate,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Making must be a non-negative number.")]
        decimal? Making,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Rate must be a non-negative number.")]
        decimal? Rate
    );
}
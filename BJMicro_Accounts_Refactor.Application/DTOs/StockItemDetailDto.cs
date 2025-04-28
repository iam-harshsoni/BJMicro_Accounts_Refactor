using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record StockItemDetailDto
    (
        long Id,
        long? ItemId,
        decimal? Qty,
        decimal? Weight,
        string? Unit,
        decimal? Melting,
        decimal? Carret,
        string? Remarks,
        DateTime? CreatedDate,
        DateTime? UpadtedDate
    );

    public record CreateStockItemDetailDto
    (
        [Required(ErrorMessage = "Item Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Item Id must be greater than 0.")]
        long? ItemId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Quantity must be a non-negative number.")]
        decimal? Qty,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative number.")]
        decimal? Weight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Melting must be a non-negative number.")]
        decimal? Melting,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Carret must be a non-negative number.")]
        decimal? Carret,

        [StringLength(200, ErrorMessage = "Remarks cannot exceed 200 characters.")]
        string? Remarks
    );

    public record UpdateStockItemDetailDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "Id must be greater than 0.")]
        long Id,

        [Required(ErrorMessage = "Item Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Item Id must be greater than 0.")]
        long? ItemId,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Quantity must be a non-negative number.")]
        decimal? Qty,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative number.")]
        decimal? Weight,

        [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
        string? Unit,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Melting must be a non-negative number.")]
        decimal? Melting,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Carret must be a non-negative number.")]
        decimal? Carret,

        [StringLength(200, ErrorMessage = "Remarks cannot exceed 200 characters.")]
        string? Remarks
    );
}
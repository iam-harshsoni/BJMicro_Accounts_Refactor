using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record PurchaseDetailDto
(
    long PdetailsId,
    long? PurchaseId,
    long? ProductId,
    decimal? Qty,
    decimal? Weight,
    string? Unit,
    decimal? Karat,
    decimal? KRate,
    decimal? Melting,
    decimal? PurchaseMelting,
    decimal? Making,
    decimal? Fine,
    decimal? Rate,
    DateTime? CreatedDate,
    DateTime? UpdatedDate
);

public record CreatePurchaseDetailDto
(
    [Required(ErrorMessage = "PurchaseId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "PurchaseId must be greater than 0.")]
    long? PurchaseId,

    [Required(ErrorMessage = "ProductId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "ProductId must be greater than 0.")]
    long? ProductId,

    // Qty can be optional, but when specified it must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Qty must be a non-negative value.")]
    decimal? Qty,

    // Weight should be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative value.")]
    decimal? Weight,

    // Unit field is optional, but we restrict its length.
    [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
    string? Unit,

    // Karat must be non-negative, adjust the range if needed.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Karat must be non-negative.")]
    decimal? Karat,

    // KRate must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "KRate must be non-negative.")]
    decimal? KRate,

    // Melting must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Melting must be non-negative.")]
    decimal? Melting,

    // PurchaseMelting must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "PurchaseMelting must be non-negative.")]
    decimal? PurchaseMelting,

    // Making must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Making must be non-negative.")]
    decimal? Making,

    // Fine must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Fine must be non-negative.")]
    decimal? Fine,

    // Rate must be non-negative.
    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Rate must be non-negative.")]
    decimal? Rate
);

public record UpdatePurchaseDetailDto
(
    [Range(1, long.MaxValue, ErrorMessage = "PdetailsId must be greater than 0.")]
    long PdetailsId,

    [Required(ErrorMessage = "PurchaseId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "PurchaseId must be greater than 0.")]
    long? PurchaseId,

    [Required(ErrorMessage = "ProductId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "ProductId must be greater than 0.")]
    long? ProductId,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Qty must be a non-negative value.")]
    decimal? Qty,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Weight must be a non-negative value.")]
    decimal? Weight,

    [StringLength(50, ErrorMessage = "Unit cannot exceed 50 characters.")]
    string? Unit,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Karat must be non-negative.")]
    decimal? Karat,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "KRate must be non-negative.")]
    decimal? KRate,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Melting must be non-negative.")]
    decimal? Melting,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "PurchaseMelting must be non-negative.")]
    decimal? PurchaseMelting,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Making must be non-negative.")]
    decimal? Making,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Fine must be non-negative.")]
    decimal? Fine,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Rate must be non-negative.")]
    decimal? Rate
);
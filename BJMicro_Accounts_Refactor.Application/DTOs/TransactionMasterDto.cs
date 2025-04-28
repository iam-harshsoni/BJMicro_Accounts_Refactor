using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record TransactionMasterDto
    (
        long TId,
        DateTime TDate,
        string? VoucherType,
        long? VoucherRefNo,
        decimal? CrAmt,
        decimal? DrAmt,
        long? LedgerId,
        DateTime? CreatedDate,
        DateTime? UpdatedDate,
        long? LoginId
    );

    public record CreateTransactionMasterDto
    (
        [Required(ErrorMessage = "Transaction Date is required.")]
        DateTime TDate,

        [Required(ErrorMessage = "Voucher Type is required.")]
        [StringLength(50, ErrorMessage = "Voucher Type cannot exceed 50 characters.")]
        string? VoucherType,

        [Required(ErrorMessage = "Voucher Reference No is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Voucher Reference No must be greater than 0.")]
        long? VoucherRefNo,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Credit Amount must be a non-negative number.")]
        decimal? CrAmt,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Debit Amount must be a non-negative number.")]
        decimal? DrAmt,

        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        [Range(1, long.MaxValue, ErrorMessage = "Login Id must be greater than 0.")]
        long? LoginId
    );

    public record UpdateTransactionMasterDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "Transaction Id must be greater than 0.")]
        long TId,

        [Required(ErrorMessage = "Transaction Date is required.")]
        DateTime TDate,

        [Required(ErrorMessage = "Voucher Type is required.")]
        [StringLength(50, ErrorMessage = "Voucher Type cannot exceed 50 characters.")]
        string? VoucherType,

        [Required(ErrorMessage = "Voucher Reference No is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Voucher Reference No must be greater than 0.")]
        long? VoucherRefNo,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Credit Amount must be a non-negative number.")]
        decimal? CrAmt,

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Debit Amount must be a non-negative number.")]
        decimal? DrAmt,

        [Required(ErrorMessage = "Ledger Id is required.")]
        [Range(1, long.MaxValue, ErrorMessage = "Ledger Id must be greater than 0.")]
        long? LedgerId,

        [Range(1, long.MaxValue, ErrorMessage = "Login Id must be greater than 0.")]
        long? LoginId
    );
}
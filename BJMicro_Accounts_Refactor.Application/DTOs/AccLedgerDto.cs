using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record AccLedgerDto
(
    long Id,
    long GroupId,
    string? LedgerName,
    decimal? OpBalance,
    string? OpBalanceDc,
    int? Type,
    string? Notes,
    int? DrId,
    int? CrId,
    DateTime? CreatedDate,
    DateTime? UpdatedDate
);

public record CreateAccLedgerDto
(
    [Required(ErrorMessage = "GroupId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "GroupId must be greater than 0.")]
    long GroupId,

    [Required(ErrorMessage = "Ledger Name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Ledger Name must be between 2 and 100 characters.")]
    string? LedgerName,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Opening balance cannot be negative.")]
    decimal? OpBalance,

    [RegularExpression("^(D|C)$", ErrorMessage = "OpBalanceDc must be either 'D' (Debit) or 'C' (Credit).")]
    string? OpBalanceDc,
    
    LedgerEntryType? EntryType,
    
    string? Notes,

    [Range(0, int.MaxValue, ErrorMessage = "DrId must be a non-negative integer.")]
    int? DrId,

    [Range(0, int.MaxValue, ErrorMessage = "CrId must be a non-negative integer.")]
    int? CrId
);

public record UpdateAccLedgerDto
(
    [Range(1, long.MaxValue, ErrorMessage = "Id must be greater than 0.")]
    long Id,

    [Required(ErrorMessage = "GroupId is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "GroupId must be greater than 0.")]
    long GroupId,

    [Required(ErrorMessage = "Ledger Name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Ledger Name must be between 2 and 100 characters.")]
    string? LedgerName,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Opening balance cannot be negative.")]
    decimal? OpBalance,

    [RegularExpression("^(D|C)$", ErrorMessage = "OpBalanceDc must be either 'D' (Debit) or 'C' (Credit).")]
    string? OpBalanceDc,
    
    LedgerEntryType? EntryType,
    
    string? Notes,

    [Range(0, int.MaxValue, ErrorMessage = "DrId must be a non-negative integer.")]
    int? DrId,

    [Range(0, int.MaxValue, ErrorMessage = "CrId must be a non-negative integer.")]
    int? CrId
);
using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record EntryDto
(
    long VoucherRefNo,
    int? EntryType,
    long? CrId,
    long? DrId,
    decimal? Amt,
    DateOnly? Date,
    string? StringDate,
    string? Remarks,
    DateTime? CreatedDate,
    DateTime? UpdatedDate
);

public record CreateEntryDto
(
    [Required(ErrorMessage = "Entry Type is required.")] int? EntryType,
    long? CrId,
    long? DrId,
    [Required(ErrorMessage = "Amount is required.")] decimal? Amt,
    [Required(ErrorMessage = "Date is required.")] DateOnly? Date,
    string? StringDate,
    string? Remarks
);

public record UpdateEntryDto
(
    long VoucherRefNo,
    [Required(ErrorMessage = "Entry Type is required.")] int? EntryType,
    long? CrId,
    long? DrId,
    [Required(ErrorMessage = "Amount is required.")] decimal? Amt,
    [Required(ErrorMessage = "Date is required.")] DateOnly? Date,
    string? StringDate,
    string? Remarks
);
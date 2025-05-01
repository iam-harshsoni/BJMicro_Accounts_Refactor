using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record EntryDetailDto
(
    long PDetailsId,
    long? VoucherRefNo,
    long? PurchaseSalesIds,
    decimal? AmtPaid,
    DateTime? CreatedDate,
    DateTime? UpdatedDate
);

public record CreateEntryDetailDto
(
    [Required(ErrorMessage = "VoucherRefNo is required.")] long? VoucherRefNo,
    [Required(ErrorMessage = "PurchaseSalesIds is required.")] long? PurchaseSalesIds,
    [Required(ErrorMessage = "Amount Paid is required.")] decimal? AmtPaid
);

public record UpdateEntryDetailDto
(
    long PDetailsId,
    [Required(ErrorMessage = "VoucherRefNo is required.")] long? VoucherRefNo,
    [Required(ErrorMessage = "PurchaseSalesIds is required.")] long? PurchaseSalesIds,
    [Required(ErrorMessage = "Amount Paid is required.")] decimal? AmtPaid
);
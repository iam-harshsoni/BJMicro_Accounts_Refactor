using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record TaxDetailDto
(
    long TaxDetailsId,
    long? TId,
    decimal? CgstPer,
    decimal? CgstRate,
    decimal? SgstPer,
    decimal? SgstRate,
    decimal? IgstPer,
    decimal? IgstRate,
    DateTime? CDate,
    DateTime? UDate
);

public record CreateTaxDetailDto
(
    [Required(ErrorMessage = "Tax Master Id is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "Tax Master Id must be greater than 0.")]
    long? TId,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "CgstPer must be a non-negative number.")]
    decimal? CgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "CgstRate must be a non-negative number.")]
    decimal? CgstRate,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "SgstPer must be a non-negative number.")]
    decimal? SgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "SgstRate must be a non-negative number.")]
    decimal? SgstRate,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "IgstPer must be a non-negative number.")]
    decimal? IgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "IgstRate must be a non-negative number.")]
    decimal? IgstRate
);

public record UpdateTaxDetailDto
(
    [Range(1, long.MaxValue, ErrorMessage = "TaxDetailsId must be greater than 0.")]
    long TaxDetailsId,

    [Required(ErrorMessage = "Tax Master Id is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "Tax Master Id must be greater than 0.")]
    long? TId,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "CgstPer must be a non-negative number.")]
    decimal? CgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "CgstRate must be a non-negative number.")]
    decimal? CgstRate,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "SgstPer must be a non-negative number.")]
    decimal? SgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "SgstRate must be a non-negative number.")]
    decimal? SgstRate,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "IgstPer must be a non-negative number.")]
    decimal? IgstPer,

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "IgstRate must be a non-negative number.")]
    decimal? IgstRate
);
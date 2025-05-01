using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record UserLoginDto
(
    long Id,
    long? UserId,
    string? LoginId,
    DateTime? LastLogin,
    DateTime? CreatedDate,
    DateTime? UpdateDate
);

public record CreateUserLoginDto
(
    [Required(ErrorMessage = "User Id is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "User Id must be greater than 0.")]
    long? UserId,

    [Required(ErrorMessage = "Login Id is required.")]
    [StringLength(50, ErrorMessage = "Login Id cannot exceed 50 characters.")]
    string LoginId,

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
    string Password,

    DateTime? LastLogin
);

public record UpdateUserLoginDto
(
    [Range(1, long.MaxValue, ErrorMessage = "Id must be greater than 0.")]
    long Id,

    [Required(ErrorMessage = "User Id is required.")]
    [Range(1, long.MaxValue, ErrorMessage = "User Id must be greater than 0.")]
    long? UserId,

    [Required(ErrorMessage = "Login Id is required.")]
    [StringLength(50, ErrorMessage = "Login Id cannot exceed 50 characters.")]
    string LoginId,

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
    string Password,

    DateTime? LastLogin
);
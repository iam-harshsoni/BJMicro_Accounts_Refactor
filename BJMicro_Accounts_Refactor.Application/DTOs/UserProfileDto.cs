using System;
using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record UserProfileDto
    (
        long UserId,
        string? Email,
        string? FirstName,
        string? LastName,
        decimal? Mobile,
        DateTime? CreatedDate,
        DateTime? UpdateDate
    );

    public record CreateUserProfileDto
    (
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        string Email,

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        string FirstName,

        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        string? LastName,

        [Required(ErrorMessage = "Mobile number is required.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Mobile number must be a valid 10-digit number.")]
        decimal Mobile
    );

    public record UpdateUserProfileDto
    (
        [Range(1, long.MaxValue, ErrorMessage = "User Id must be greater than 0.")]
        long UserId,

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        string Email,

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        string FirstName,

        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        string? LastName,

        [Required(ErrorMessage = "Mobile number is required.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Mobile number must be a valid 10-digit number.")]
        decimal Mobile
    );
}
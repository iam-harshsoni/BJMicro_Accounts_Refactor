// DTO used for reading the full information from TblItemMaster
using System.ComponentModel.DataAnnotations;

public record TblItemMasterDto(
    long Id,
    string? ItemCode,
    long? CategoryId,
    byte[]? Photo,
    DateTime? CreatedDate,
    DateTime? UpdateDate
);

// DTO for creating a new item
public record CreateItemDto(

    [Required(ErrorMessage = "Item code is required.")] string? ItemCode,
    long? CategoryId,
    byte[]? Photo
);

// DTO for updating an existing item
public record UpdateItemDto(
    [Required(ErrorMessage = "Item code is required.")] string? ItemCode,
    long? CategoryId,
    byte[]? Photo
);
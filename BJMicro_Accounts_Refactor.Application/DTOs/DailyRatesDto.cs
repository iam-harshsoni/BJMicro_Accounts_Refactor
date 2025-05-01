using System.ComponentModel.DataAnnotations;

namespace BJMicro_Accounts_Refactor.Core.DTOs;

public record DailyRateDto(
    long Id,
    decimal? FineGold,
    decimal? Hallmark,
    decimal? HallmarkBuyBack,
    decimal? TwentyTwoC,
    decimal? TwentyThreeC,
    decimal? EighteenC,
    decimal? Silver,
    DateTime? Date
);

public record CreateDailyRateDto(

    [Required(ErrorMessage = "FineGold is required.")] decimal? FineGold,
    [Required(ErrorMessage = "Hallmark is required.")] decimal? Hallmark,
    [Required(ErrorMessage = "HallmarkBuyBack is required.")] decimal? HallmarkBuyBack,
    [Required(ErrorMessage = "TwentyTwoC is required.")] decimal? TwentyTwoC,
    [Required(ErrorMessage = "TwentyThreeC is required.")] decimal? TwentyThreeC,
    [Required(ErrorMessage = "EighteenC is required.")] decimal? EighteenC,
    [Required(ErrorMessage = "Silver is required.")] decimal? Silver

//add Createdate and UpdateDate value in DTO Mapping for 'Update Feature'
);

public record UpdateDailyRateDto(
    long Id,
    [Required(ErrorMessage = "FineGold is required.")] decimal? FineGold,
    [Required(ErrorMessage = "Hallmark is required.")] decimal? Hallmark,
    [Required(ErrorMessage = "HallmarkBuyBack is required.")] decimal? HallmarkBuyBack,
    [Required(ErrorMessage = "TwentyTwoC is required.")] decimal? TwentyTwoC,
    [Required(ErrorMessage = "TwentyThreeC is required.")] decimal? TwentyThreeC,
    [Required(ErrorMessage = "EighteenC is required.")] decimal? EighteenC,
    [Required(ErrorMessage = "Silver is required.")] decimal? Silver

//add UpdateDate value in DTO Mapping for 'Update Feature'
);

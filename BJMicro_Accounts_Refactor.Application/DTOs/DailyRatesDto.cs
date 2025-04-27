namespace BJMicro_Accounts_Refactor.Core.DTOs
{
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
        decimal? FineGold,
        decimal? Hallmark,
        decimal? HallmarkBuyBack,
        decimal? TwentyTwoC,
        decimal? TwentyThreeC,
        decimal? EighteenC,
        decimal? Silver

    //add Createdate and UpdateDate value in DTO Mapping for 'Update Feature'
    );

    public record UpdateDailyRateDto(
        long Id,
        decimal? FineGold,
        decimal? Hallmark,
        decimal? HallmarkBuyBack,
        decimal? TwentyTwoC,
        decimal? TwentyThreeC,
        decimal? EighteenC,
        decimal? Silver

    //add UpdateDate value in DTO Mapping for 'Update Feature'
    );


}

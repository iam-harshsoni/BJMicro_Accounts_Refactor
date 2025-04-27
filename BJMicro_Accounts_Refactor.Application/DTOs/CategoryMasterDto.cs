
namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public record CategoryMasterDto
    (
        long CId,
        string? CName,
        string? Prefix,
        DateTime? CreateDate,
        DateTime? UpdateDate
    );
}

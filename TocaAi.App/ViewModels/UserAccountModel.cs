namespace TocaAi.App.ViewModels
{
    public record UserAccountModel(
        Guid Id,
        string Email,
        UserRole Role,
        bool IsActive
    );
}

namespace TocaAi.App.ViewModels
{
    public record UserAccountModel(
        Guid Id,
        string Username,
        string Email,
        UserRole Role,
        bool IsActive
    );
}

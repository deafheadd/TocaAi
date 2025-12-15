namespace TocaAi.App.ViewModels
{
    public record PersonModel(
        Guid Id,
        string FullName,
        string DocumentNumber,
        string PhoneNumber,
        DateTime RegisterDate,
        // endereço
        string Street,
        string Number,
        string Neighborhood,
        string City,
        string State,
        string PostalCode
    );
}

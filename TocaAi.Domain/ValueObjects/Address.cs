namespace TocaAi.Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; }
        public string Number { get; }
        public string Neighborhood { get; }
        public string City { get; }
        public string State { get; }
        public string PostalCode { get; }

        public string? Complement { get; }
        public Address(string street, string number, string neighborhood, string city, string state, string postalCode, string complement)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            PostalCode = postalCode;
            Complement = complement;
        }
    }
}

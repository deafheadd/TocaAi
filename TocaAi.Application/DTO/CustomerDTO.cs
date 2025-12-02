public record CustomerDTO
(
    Guid Id,
    string FullName,
    string Email,
    string CPF,
    string Address,
    DateTime RegisterDate,
    bool IsActive
);
using Market.Domain.Common;

namespace Market.Domain.Entities;

/// <summary>
/// Клиент
/// </summary>
public class Customer : IEntity
{
    /// <inheritdoc />
    public Guid Id { get; set; }
}
using Market.Domain.Common;

namespace Market.Domain.Entities;

/// <summary>
/// Товар
/// </summary>
public class Product : IEntity
{
    /// <inheritdoc />
    public Guid Id { get; set; }
}
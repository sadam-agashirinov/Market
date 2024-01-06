using Market.Domain.Common;

namespace Market.Domain.Entities;

/// <summary>
/// Позиция заказа
/// </summary>
public class OrderItem : IEntity
{
    /// <inheritdoc />
    public Guid Id { get; set; }

    /// <summary>
    /// Идентфикатор заказа
    /// </summary>
    public Order OrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public Order Order { get; set; }
}
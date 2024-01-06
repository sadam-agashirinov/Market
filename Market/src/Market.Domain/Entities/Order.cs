using Market.Domain.Common;
using Market.Domain.Enums.Order;

namespace Market.Domain.Entities;

/// <summary>
/// Заказ
/// </summary>
public class Order : IEntity
{
    /// <inheritdoc />
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// Позиции заказа
    /// </summary>
    public List<OrderItem> Items { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public Customer Customer { get; set; }
}
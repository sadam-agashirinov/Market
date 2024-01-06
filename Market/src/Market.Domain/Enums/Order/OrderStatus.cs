namespace Market.Domain.Enums.Order;

/// <summary>
/// Статус заказа
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Новый
    /// </summary>
    New = 0,
    /// <summary>
    /// Обработка заказа
    /// </summary>
    Processing = 1,
    /// <summary>
    /// Ожидание оплаты
    /// </summary>
    WaitPayment = 2,
    /// <summary>
    /// Оплочено
    /// </summary>
    Paid = 3,
    /// <summary>
    /// Принят
    /// </summary>
    Accepted = 4,
    /// <summary>
    /// Доставка
    /// </summary>
    Delivering = 5,
    /// <summary>
    /// Доставлено
    /// </summary>
    Delivered = 6,
    /// <summary>
    /// Отменен
    /// </summary>
    Canceled = 7
}
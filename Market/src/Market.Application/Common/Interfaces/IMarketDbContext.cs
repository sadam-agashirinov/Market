using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.Application.Common.Interfaces;

/// <summary>
/// Интерфейс контекста базы данных
/// </summary>
public interface IMarketDbContext
{
    /// <summary>
    /// Клиенты
    /// </summary>
    public DbSet<Customer> Customers { get; }

    /// <summary>
    /// Заказы
    /// </summary>
    public DbSet<Order> Orders { get; }

    /// <summary>
    /// Товары
    /// </summary>
    public DbSet<Product> Products { get; }
}
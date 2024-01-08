namespace Market.Application.Common.Exceptions;

/// <summary>
/// Исключение Сущность не найдена.
/// </summary>
public class NotFoundException : Exception
{
    /// <summary>
    /// Конструктор исключения.
    /// </summary>
    /// <param name="name">Наименование сущности</param>
    /// <param name="key">Ключь сущности, по которому производился поиск</param>
    public NotFoundException(string name, string key) : base($"Entity \"{name}\" ({key}) not found.") { }
}
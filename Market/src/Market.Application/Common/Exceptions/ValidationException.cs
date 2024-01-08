using FluentValidation.Results;

namespace Market.Application.Common.Exceptions;

/// <summary>
/// Исключение Ошибка валидации.
/// </summary>
public class ValidationException : Exception
{
    /// <summary>
    /// Ошибки
    /// </summary>
    public IDictionary<string, string[]> Errors { get; }

    public ValidationException()
        : base("One or more validation failures have occurred.")
    {
        Errors = new Dictionary<string, string[]>();
    }
    
    public ValidationException(IEnumerable<ValidationFailure> failures)
        : this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}
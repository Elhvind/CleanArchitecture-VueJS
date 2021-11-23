namespace CleanArchitecture.Application.Common.Interfaces;

/// <inheritdoc cref="DateTimeOffset" />
public interface IDateTimeOffset
{
    /// <inheritdoc cref="DateTimeOffset.Now" />
    DateTimeOffset Now { get; }

    /// <inheritdoc cref="DateTimeOffset.UtcNow" />
    DateTimeOffset UtcNow { get; }
}

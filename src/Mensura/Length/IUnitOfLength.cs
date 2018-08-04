using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents a unit of length in the system
  /// </summary>
  public interface IUnitOfLength
    : IComparable<IUnitOfLength>, IEquatable<IUnitOfLength>
  {
    /// <summary>
    /// Gets the value
    /// </summary>
    decimal Value { get; }

    /// <summary>
    /// Add the specified value to the existing value
    /// </summary>
    /// <param name="valueToAdd">
    /// The value to add
    /// </param>
    void Add(decimal valueToAdd);

    /// <summary>
    /// Add the specified value to the existing value
    /// </summary>
    /// <param name="valueToAdd">
    /// The value to add
    /// </param>
    void Add(IUnitOfLength valueToAdd);

    /// <summary>
    /// Convert the value to the Internal System of Units (SI) <see cref="Metre"/>
    /// </summary>
    /// <returns>
    /// The value, converted to the SI <see cref="Metre" />
    /// </returns>
    Metre ToSI();
  }
}

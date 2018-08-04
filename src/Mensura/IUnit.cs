using System;

namespace Mensura
{
  /// <summary>
  /// Represents an unit in the system
  /// </summary>
  public interface IUnit
    : ICloneable
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
  }
}

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
  }
}

using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents the Internal System of Units (SI) Decametre
  /// </summary>
  public sealed class Decametre
  : UnitOfLength<Decametre>
  {
    /// <summary>
    /// Initializes a new instance of <see cref="Decametre"/>
    /// </summary>
    public Decametre()
      : base()
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="Decametre"/> with the
    /// specified value
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    public Decametre(decimal value)
      : base(value)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="Decametre"/> with the
    /// specified value and <see cref="ValueType"/>
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    /// <param name="type">
    /// The <see cref="ValueType"/> of the value
    /// </param>
    public Decametre(decimal value, ValueType type)
      : base(value, type)
    {
    }

    /// <summary>
    /// Convert the specified native value to the corresponding Internal System
    /// of Units (SI) value
    /// </summary>
    /// <param name="nativeValue">
    /// The native value
    /// </param>
    /// <returns>
    /// The native value, converted to the Internal System of Units (SI) value
    /// </returns>
    protected override decimal ToSI(decimal nativeValue)
    {
      var result = nativeValue * 10;

      return result;
    }

    /// <summary>
    /// Convert the specified Internal System of Units (SI) value to the
    /// corresponding native value
    /// </summary>
    /// <param name="siValue">
    /// The Internal System of Units (SI) value
    /// </param>
    /// <returns>
    /// The specified Internal System of Units (SI) value, converted to the
    /// corresponding native value
    /// </returns>
    protected override decimal FromSI(decimal siValue)
    {
      var result = siValue / 10;

      return result;
    }
  }
}

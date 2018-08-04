using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents the Internal System of Units (SI) metre
  /// </summary>
  public sealed class Metre
    : UnitOfLength<Metre>
  {
    /// <summary>
    /// Initializes a new instance of <see cref="Metre"/>
    /// </summary>
    public Metre()
      : base()
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="Metre"/> with the
    /// specified value
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    public Metre(decimal value)
      : base(value)
    {
    }

    /// <summary>
    /// Convert the value to the Internal System of Units (SI) <see cref="Metre"/>
    /// </summary>
    /// <returns>
    /// The value, converted to the SI <see cref="Metre" />
    /// </returns>
    public override Metre ToSI() => this;

    /// <summary>
    /// Convert the Internal System Of Units (SI) <see cref="Metre"/> to the
    /// correct decimal value for this <see cref="UnitOfLength"/>
    /// </summary>
    /// <param name="siValue">
    /// The SI <see cref="Metre"/> value to convert
    /// </param>
    /// <returns>
    /// The specified SI <see cref="Metre"/> converted to the correct value
    /// </returns>
    protected override decimal FromSI(Metre siValue)
    {
      _ = siValue ?? throw new ArgumentNullException(nameof(siValue));

      var result = siValue.Value;

      return result;
    }
  }
}

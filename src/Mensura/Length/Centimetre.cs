﻿using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents the Internal System of Units (SI) centimetre
  /// </summary>
  public sealed class Centimetre
  : UnitOfLength<Centimetre>
  {
    /// <summary>
    /// Initializes a new instance of <see cref="Centimetre"/>
    /// </summary>
    public Centimetre()
      : base()
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="Centimetre"/> with the
    /// specified value
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    public Centimetre(decimal value)
      : base(value)
    {
    }

    /// <summary>
    /// Convert the value to the Internal System of Units (SI) <see cref="Metre"/>
    /// </summary>
    /// <returns>
    /// The value, converted to the SI <see cref="Metre" />
    /// </returns>
    public override Metre ToSI()
    {
      Metre result;

      if (this.Value != 0)
      {
        result = new Metre(this.Value / 100);
      }
      else
      {
        result = new Metre(0);
      }

      return result;
    }

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

      var result = siValue.Value * 100;

      return result;
    }
  }
}

﻿using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents a unit of length
  /// </summary>
  public abstract class UnitOfLength
    : IUnitOfLength
  {
    /// <summary>
    /// Gets or sets the backing field for the <see cref="Value"/> property
    /// </summary>
    private decimal _value;

    /// <summary>
    /// Gets or sets the cached Internal System of Units (SI) <see cref="UnitOfLength"/>
    /// </summary>
    private IUnitOfLength _siValue;

    /// <summary>
    /// Gets the value
    /// </summary>
    public decimal Value
    {
      get
      {
        return this._value;
      }
      protected set
      {
        this._value = value;

        this._siValue = this.ToSI();
      }
    }

    /// <summary>
    /// Add the specified value to the existing value
    /// </summary>
    /// <param name="valueToAdd">
    /// The value to add
    /// </param>
    public virtual void Add(decimal valueToAdd)
    {
      var newValue = this.Value + valueToAdd;

      if (newValue <= 0)
      {
        newValue = 0;
      }

      this.Value = newValue;
    }

    /// <summary>
    /// Add the specified value to the existing value
    /// </summary>
    /// <param name="valueToAdd">
    /// The value to add
    /// </param>
    public virtual void Add(IUnitOfLength valueToAdd)
    {
      _ = valueToAdd ?? throw new ArgumentNullException(nameof(valueToAdd));

      this.Value += valueToAdd.ToSI().Value;
    }

    /// <summary>
    /// Convert the value to the Internal System of Units (SI) <see cref="Metre"/>
    /// </summary>
    /// <returns>
    /// The value, converted to the SI <see cref="Metre" />
    /// </returns>
    public abstract Metre ToSI();

    /// <summary>
    /// Compares the current instance with another object of the same type and
    /// returns an integer that indicates whether the current instance precedes,
    /// follows, or occurs in the same position in the sort order as the other object
    /// </summary>
    /// <param name="other">
    /// An object to compare with this instance
    /// </param>
    /// <returns>
    /// A value that indicates the relative order of the objects being compared.
    /// The return value has these meanings: Value Meaning Less than zero This
    /// instance precedes other in the sort order. Zero This instance occurs in
    /// the same position in the sort order as other. Greater than zero This
    /// instance follows other in the sort order
    /// </returns>
    public virtual int CompareTo(IUnitOfLength other)
    {
      var thisSiValue = this._siValue.Value;

      if (other == null || thisSiValue == other.ToSI().Value)
        return 0;
      else if (thisSiValue > other.ToSI().Value)
        return -1;
      else
        return 1;
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the
    /// same type
    /// </summary>
    /// <param name="other">
    /// An object to compare with this object
    /// </param>
    /// <returns>
    /// True if the current object is equal to the other parameter; otherwise, false
    /// </returns>
    public virtual bool Equals(IUnitOfLength other)
    {
      var result = other != null && this._siValue.Value == other.ToSI().Value;

      return result;
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the
    /// same type
    /// </summary>
    /// <param name="obj">
    /// An object to compare with this object
    /// </param>
    /// <returns>
    /// True if the current object is equal to the other parameter; otherwise, false
    /// </returns>
    public override bool Equals(object obj)
    {
      var result = false;

      if (obj is IUnitOfLength otherUnitOfLength)
      {
        result = this._siValue.Value == otherUnitOfLength.ToSI().Value;
      }

      return result;
    }

    /// <summary>
    /// Serves as the default hash function
    /// </summary>
    /// <returns>
    /// A 32-bit signed integer hash code
    /// </returns>
    public override int GetHashCode() => this.Value.GetHashCode();

    /// <summary>
    /// Overrides the equality (==) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left and right match; false otherwise
    /// </returns>
    public static bool operator ==(UnitOfLength left, IUnitOfLength right) => left.Equals(right);

    /// <summary>
    /// Overrides the not-equals (!=) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left and right do not match; false otherwise
    /// </returns>
    public static bool operator !=(UnitOfLength left, IUnitOfLength right) => !left.Equals(right);

    /// <summary>
    /// Overrides the less-than (&lt;) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left is less than right; false otherwise
    /// </returns>
    public static bool operator <(UnitOfLength left, IUnitOfLength right) => left.ToSI().Value < right.ToSI().Value;

    /// <summary>
    /// Overrides the less-than-or-equal-to (&lt;=) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left is less than or equal to right; false otherwise
    /// </returns>
    public static bool operator <=(UnitOfLength left, IUnitOfLength right) => left.ToSI().Value <= right.ToSI().Value;

    /// <summary>
    /// Overrides the greater-than (&gt;) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left is greater than right; false otherwise
    /// </returns>
    public static bool operator >(UnitOfLength left, IUnitOfLength right) => left.ToSI().Value > right.ToSI().Value;

    /// <summary>
    /// Overrides the greater-than-or-equal-to (&gt;=) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the comparison
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the comparison
    /// </param>
    /// <returns>
    /// True when left is greater than or equal to right; false otherwise
    /// </returns>
    public static bool operator >=(UnitOfLength left, IUnitOfLength right) => left.ToSI().Value >= right.ToSI().Value;
  }
}

using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents a unit of length
  /// </summary>
  public abstract class UnitOfLength
    : Unit, ISIConvertable<Metre>, IComparable<UnitOfLength>, IEquatable<UnitOfLength>
  {
    /// <summary>
    /// Gets the value
    /// </summary>
    public override decimal Value
    {
      get;
    }

    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength"/>
    /// </summary>
    protected UnitOfLength() => this.Value = 0;

    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength"/> with the
    /// specified value
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    protected UnitOfLength(decimal value)
      : this(value, ValueType.NonSI)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength"/> with the
    /// specified value and <see cref="ValueType"/>
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    /// <param name="type">
    /// The <see cref="ValueType"/> of the value
    /// </param>
    protected UnitOfLength(decimal value, ValueType type)
    {
      if (value < 0)
        throw new ArgumentOutOfRangeException("Value cannot be less than 0");

      switch (type)
      {
        case ValueType.NonSI:
          {
            this.Value = value;
            break;
          }
        case ValueType.SI:
          {
            this.Value = this.FromSI(value);
            break;
          }
        default:
          throw new InvalidOperationException($"Specified value type '{type}' is not supported");
      }
    }

    /// <summary>
    /// Convert the value to the Internal System of Units (SI) <see cref="Metre"/>
    /// </summary>
    /// <returns>
    /// The value, converted to the SI <see cref="Metre" />
    /// </returns>
    public virtual Metre ToSI()
    {
      Metre result;

      if (this.Value != 0)
      {
        result = new Metre(this.ToSI(this.Value));
      }
      else
      {
        result = new Metre(0);
      }

      return result;
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
    protected abstract decimal ToSI(decimal nativeValue);

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
    protected abstract decimal FromSI(decimal siValue);

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
    public virtual int CompareTo(UnitOfLength other)
    {
      var thisSiValue = this.ToSI().Value;

      var result = 0;

      if (other == (object)null)
        result = 1;
      else
        result = thisSiValue.CompareTo(other.ToSI().Value);

      return result;
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
    public virtual bool Equals(UnitOfLength other)
    {
      var result = other != (object)null && this.ToSI().Value == other.ToSI().Value;

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

      if (obj is UnitOfLength otherUnitOfLength)
      {
        result = this.ToSI().Value == otherUnitOfLength.ToSI().Value;
      }
      else if (obj is IComparable otherValue)
      {
        result = this.Value.CompareTo(otherValue) == 0;
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

    public static bool operator ==(UnitOfLength left, UnitOfLength right) => left.Equals(right);
    public static bool operator ==(UnitOfLength left, IComparable right) => left.Value.Equals(right);
    public static bool operator !=(UnitOfLength left, UnitOfLength right) => !left.Equals(right);
    public static bool operator !=(UnitOfLength left, IComparable right) => !left.Value.Equals(right);
    public static bool operator <(UnitOfLength left, UnitOfLength right) => left.ToSI().Value < right.ToSI().Value;
    public static bool operator <(UnitOfLength left, IComparable right) => left.Value.CompareTo(right) < 0;
    public static bool operator <=(UnitOfLength left, UnitOfLength right) => left.ToSI().Value <= right.ToSI().Value;
    public static bool operator <=(UnitOfLength left, IComparable right) => left.Value.CompareTo(right) <= 0;
    public static bool operator >(UnitOfLength left, UnitOfLength right) => left.ToSI().Value > right.ToSI().Value;
    public static bool operator >(UnitOfLength left, IComparable right) => left.Value.CompareTo(right) > 0;
    public static bool operator >=(UnitOfLength left, UnitOfLength right) => left.ToSI().Value >= right.ToSI().Value;
    public static bool operator >=(UnitOfLength left, IComparable right) => left.Value.CompareTo(right) >= 0;
  }
}

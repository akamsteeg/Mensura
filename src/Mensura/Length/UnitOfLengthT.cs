using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents a unit of length
  /// </summary>
  /// <typeparam name="T">
  /// The concrete <see cref="UnitOfLength"/> this class represents
  /// </typeparam>
  public abstract class UnitOfLength<T>
    : UnitOfLength
    where T : UnitOfLength, new()
  {
    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength{T}"/>
    /// </summary>
    protected UnitOfLength()
      : base()
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength{T}"/> with the
    /// specified value
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    protected UnitOfLength(decimal value)
      : base(value)
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="UnitOfLength{T}"/> with the
    /// specified value and <see cref="ValueType"/>
    /// </summary>
    /// <param name="value">
    /// The value
    /// </param>
    /// <param name="type">
    /// The <see cref="ValueType"/> of the value
    /// </param>
    protected UnitOfLength(decimal value, ValueType type)
      : base(value, type)
    { }

    /// <summary>
    /// Creates a new object that is a copy of the current instance
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance
    /// </returns>
    public override object Clone()
    {
      var result = (T)Activator.CreateInstance(typeof(T), this.Value);

      return result;
    }

    public static T operator +(UnitOfLength<T> left, UnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var value = left.ToSI().Value + right.ToSI().Value;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.SI);

      return result;
    }

    public static T operator +(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var value = left.Value + right;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.NonSI);

      return result;
    }

    public static T operator +(UnitOfLength<T> left, long right) => left + (decimal)right;
    public static T operator +(UnitOfLength<T> left, int right) => left + (decimal)right;
    public static T operator +(UnitOfLength<T> left, byte right) => left + (decimal)right;
    public static T operator +(UnitOfLength<T> left, double right) => left + (decimal)right;
    public static T operator +(UnitOfLength<T> left, float right) => left + (decimal)right;

    public static T operator -(UnitOfLength<T> left, UnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var value = left.ToSI().Value - right.ToSI().Value;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.SI);

      return result;
    }

    public static T operator -(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var value = left.Value - right;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.NonSI);

      return result;
    }

    public static T operator -(UnitOfLength<T> left, long right) => left - (decimal)right;
    public static T operator -(UnitOfLength<T> left, int right) => left - (decimal)right;
    public static T operator -(UnitOfLength<T> left, byte right) => left - (decimal)right;
    public static T operator -(UnitOfLength<T> left, double right) => left - (decimal)right;
    public static T operator -(UnitOfLength<T> left, float right) => left - (decimal)right;

    public static T operator /(UnitOfLength<T> left, UnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var value = left.ToSI().Value / right.ToSI().Value;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.SI);

      return result;
    }

    public static T operator /(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var value = left.Value / right;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.NonSI);

      return result;
    }

    public static T operator /(UnitOfLength<T> left, long right) => left / (decimal)right;
    public static T operator /(UnitOfLength<T> left, int right) => left / (decimal)right;
    public static T operator /(UnitOfLength<T> left, byte right) => left / (decimal)right;
    public static T operator /(UnitOfLength<T> left, double right) => left / (decimal)right;
    public static T operator /(UnitOfLength<T> left, float right) => left / (decimal)right;

    public static T operator *(UnitOfLength<T> left, UnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var value = left.ToSI().Value * right.ToSI().Value;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.SI);

      return result;
    }

    public static T operator *(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var value = left.Value * right;

      var result = (T)Activator.CreateInstance(typeof(T), value, ValueType.NonSI);

      return result;
    }

    public static T operator *(UnitOfLength<T> left, long right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, int right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, byte right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, double right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, float right) => left * (decimal)right;
  }
}

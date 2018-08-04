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
   /// Creates a new object that is a copy of the current instance
   /// </summary>
   /// <returns>
   /// A new object that is a copy of this instance
   /// </returns>
    public override object Clone()
    {
      var result = new T();

      result.Add(this.Value);

      return result;
    }

    public static T operator +(UnitOfLength<T> left, UnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var result = new T();

      var value = left.Value + right.ToSI().Value;

      result.Add(value);

      return result;
    }

    public static T operator +(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var result = new T();

      var value = left.Value + right;

      result.Add(value);

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

      var result = new T();

      var value = left.Value - right.ToSI().Value;

      result.Add(value);

      return result;
    }

    public static T operator -(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var result = new T();

      var value = left.Value - right;

      result.Add(value);

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

      var result = new T();

      var value = left.Value / right.ToSI().Value;

      result.Add(value);

      return result;
    }

    public static T operator /(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var result = new T();

      var value = left.Value / right;

      result.Add(value);

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

      var result = new T();

      var value = left.Value * right.ToSI().Value;

      result.Add(value);

      return result;
    }

    public static T operator *(UnitOfLength<T> left, decimal right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));

      var result = new T();

      var value = left.Value * right;

      result.Add(value);

      return result;
    }

    public static T operator *(UnitOfLength<T> left, long right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, int right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, byte right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, double right) => left * (decimal)right;
    public static T operator *(UnitOfLength<T> left, float right) => left * (decimal)right;
  }
}

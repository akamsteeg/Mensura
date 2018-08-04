using System;

namespace Mensura.Length
{
  /// <summary>
  /// Represents a unit of length
  /// </summary>
  /// <typeparam name="T">
  /// The concrete <see cref="IUnitOfLength"/> this class represents
  /// </typeparam>
  public abstract class UnitOfLength<T>
    : UnitOfLength
    where T : class, IUnitOfLength, new()
  {
    /// <summary>
    /// Overrides the addition (+) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the operation
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the operation
    /// </param>
    /// <returns>
    /// A new instance of <see cref="T"/> with the two values added
    /// </returns>
    public static T operator +(UnitOfLength<T> left, IUnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var result = new T();

      var value = left.Value + right.ToSI().Value;

      result.Add(value);

      return result;
    }

    /// <summary>
    /// Overrides the subscription (-) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the operation
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the operation
    /// </param>
    /// <returns>
    /// A new instance of <see cref="T"/> with the the right value substracted from the left
    /// </returns>
    public static T operator -(UnitOfLength<T> left, IUnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var result = new T();

      var value = left.Value - right.ToSI().Value;

      result.Add(value);

      return result;
    }

    /// <summary>
    /// Overrides the division (/) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the operation
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the operation
    /// </param>
    /// <returns>
    /// A new instance of <see cref="T"/> with the left value divided by the right value
    /// </returns>
    public static T operator /(UnitOfLength<T> left, IUnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var result = new T();

      var value = left.Value / right.ToSI().Value;

      result.Add(value);

      return result;
    }

    /// <summary>
    /// Overrides the multiplication (*) operator
    /// </summary>
    /// <param name="left">
    /// The left <see cref="UnitOfLength"/> of the operation
    /// </param>
    /// <param name="right">
    /// The rigth <see cref="IUnitOfLength"/> of the operation
    /// </param>
    /// <returns>
    /// A new instance of <see cref="T"/> with the left value multiplied by the right value
    /// </returns>
    public static T operator *(UnitOfLength<T> left, IUnitOfLength right)
    {
      _ = left ?? throw new ArgumentNullException(nameof(left));
      _ = right ?? throw new ArgumentNullException(nameof(right));

      var result = new T();

      var value = left.Value * right.ToSI().Value;

      result.Add(value);

      return result;
    }
  }
}

namespace Mensura
{
  /// <summary>
  /// Represents an unit in the system
  /// </summary>
  public abstract class Unit
    : IUnit
  {
    /// <summary>
    /// Gets the value
    /// </summary>
    public virtual decimal Value
    {
      get;
    }

    /// <summary>
    /// Creates a new object that is a copy of the current instance
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance
    /// </returns>
    public abstract object Clone();
  }
}

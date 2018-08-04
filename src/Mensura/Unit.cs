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
      protected set;
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
    /// Creates a new object that is a copy of the current instance
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance
    /// </returns>
    public abstract object Clone();
  }
}

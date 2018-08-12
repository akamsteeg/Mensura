namespace Mensura
{
  /// <summary>
  /// Represents an <see cref="IUnit"/> to is convertable to it's equivalent
  /// Internal System of Units (SI) unit
  /// </summary>
  /// <typeparam name="TSIUnit">
  /// The SI <see cref="IUnit"/>
  /// </typeparam>
  public interface ISIConvertable<TSIUnit>
    where TSIUnit: class, IUnit, new()
  {
    /// <summary>
    /// Convert the value to the corresponding Internal System of Units (SI) value
    /// </summary>
    /// <returns>
    /// The value, converted to the SI equivalent
    /// </returns>
    TSIUnit ToSI();
  }
}

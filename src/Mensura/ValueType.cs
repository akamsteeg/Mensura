namespace Mensura
{
  /// <summary>
  /// Represents the type of the value
  /// </summary>
  public enum ValueType
  : byte
  {
    /// <summary>
    /// The value is native
    /// </summary>
    Native,
    /// <summary>
    /// The value is in Internal System of Units (SI) and should be converted to
    /// the native value
    /// </summary>
    SI
  }
}

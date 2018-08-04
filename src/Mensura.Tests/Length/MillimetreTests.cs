using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class MillimetreTests
    : UnitOfLengthTTests<Millimetre>
  {
    public MillimetreTests()
      : base(new Millimetre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Millimetre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Millimetre(-1));
    }
  }
}

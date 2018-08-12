using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class DecimetreTests
    : UnitOfLengthTTests<Decimetre>
  {
    public DecimetreTests()
      : base(new Decimetre(5))
    {
    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Decimetre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Decimetre(-1));
    }
  }
}

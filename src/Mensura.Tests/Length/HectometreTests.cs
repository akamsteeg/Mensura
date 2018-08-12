using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class HectometreTests
    : UnitOfLengthTTests<Hectometre>
  {
    public HectometreTests()
      : base(new Hectometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Hectometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Hectometre(-1));
    }
  }
}

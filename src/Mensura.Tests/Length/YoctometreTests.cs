using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class YoctometreTests
    : UnitOfLengthTTests<Yoctometre>
  {
    public YoctometreTests()
      : base(new Yoctometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Yoctometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Yoctometre(-1));
    }
  }
}

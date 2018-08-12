using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class ZeptometreTests
    : UnitOfLengthTTests<Zeptometre>
  {
    public ZeptometreTests()
      : base(new Zeptometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Zeptometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Zeptometre(-1));
    }
  }
}

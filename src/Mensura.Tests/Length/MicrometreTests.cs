using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class MicrometreTests
    : UnitOfLengthTTests<Micrometre>
  {
    public MicrometreTests()
      : base(new Micrometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Micrometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Micrometre(-1));
    }
  }
}

using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class PicometreTests
    : UnitOfLengthTTests<Picometre>
  {
    public PicometreTests()
      : base(new Picometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Picometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Picometre(-1));
    }
  }
}

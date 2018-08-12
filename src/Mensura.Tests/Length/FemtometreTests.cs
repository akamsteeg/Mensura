using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class FemtometreTests
    : UnitOfLengthTTests<Femtometre>
  {
    public FemtometreTests()
      : base(new Femtometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Femtometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Femtometre(-1));
    }
  }
}

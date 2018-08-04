using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class CentimetreTests
    : UnitOfLengthTTests<Centimetre>
  {
    public CentimetreTests()
      : base(new Centimetre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Centimetre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Centimetre(-1));
    }
  }
}

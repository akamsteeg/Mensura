using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class DecametreTests
    : UnitOfLengthTTests<Decametre>
  {
    public DecametreTests()
      : base(new Decametre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Decametre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Decametre(-1));
    }
  }
}

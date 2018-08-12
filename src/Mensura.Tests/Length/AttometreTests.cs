using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class AttometreTests
    : UnitOfLengthTTests<Attometre>
  {
    public AttometreTests()
      : base(new Attometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Attometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Attometre(-1));
    }
  }
}

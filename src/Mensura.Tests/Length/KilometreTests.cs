using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class KilometreTests
    : UnitOfLengthTTests<Kilometre>
  {
    public KilometreTests()
      : base(new Kilometre(5))
    {
    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Kilometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Kilometre(-1));
    }
  }
}

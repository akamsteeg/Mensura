using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class NanometreTests
    : UnitOfLengthTTests<Nanometre>
  {
    public NanometreTests()
      : base(new Nanometre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Nanometre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Nanometre(-1));
    }
  }
}

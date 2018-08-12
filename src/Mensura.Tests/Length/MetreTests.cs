using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public class MetreTests
    : UnitOfLengthTTests<Metre>
  {
    public MetreTests()
      : base(new Metre(5))
    {

    }

    [Fact]
    public void Ctor_WithZeroValue_DoesNotThrow()
    {
      _ = new Metre(0);
    }

    [Fact]
    public void Ctor_WithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new Metre(-1));
    }

    [Fact]
    public void Add_1CentimetreTo2Metres_Equals21()
    {
      var m = new Metre(2);

      m += new Centimetre(1);

      Assert.Equal(2.01m, m.Value);
    }
  }
}

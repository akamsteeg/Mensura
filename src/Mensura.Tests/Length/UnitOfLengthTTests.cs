using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public abstract class UnitOfLengthTTests<T>
    : UnitOfLengthTests
    where T: UnitOfLength, new()
  {
    protected UnitOfLengthTTests(T objectToTest)
      : base(objectToTest)
    {
    }

    [Fact]
    public void AdditionOperator_WithItself_CreatesNewObjectWithDoubleValue()
    {
      var expected = this._objectToTest.Value + this._objectToTest.Value;

      var actual = (UnitOfLength<T>)this._objectToTest + (UnitOfLength<T>)this._objectToTest;

      Assert.Equal(expected, actual.Value);
    }
  }
}

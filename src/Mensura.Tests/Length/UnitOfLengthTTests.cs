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

    [Fact]
    public void AdditionOperator_WithValueOfItself_CreatesNewObjectWithDoubleValue()
    {
      var expected = this._objectToTest.Value + this._objectToTest.Value;

      var actual = (UnitOfLength<T>)this._objectToTest + this._objectToTest.Value;

      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void SubtractionOperator_WithItself_CreatesNewObjectWithValueZero()
    {
      var actual = (UnitOfLength<T>)this._objectToTest - (UnitOfLength<T>)this._objectToTest;

      Assert.Equal(0, actual.Value);
    }

    [Fact]
    public void SubtractionOperator_WithValueOfItself_CreatesNewObjectWithValueZero()
    {
      var actual = (UnitOfLength<T>)this._objectToTest - this._objectToTest.Value;

      Assert.Equal(0, actual.Value);
    }

    [Fact]
    public void DivisionOperator_WithItself_CreatesNewObjectWithValueOne()
    {
      var actual = (UnitOfLength<T>)this._objectToTest / (UnitOfLength<T>)this._objectToTest;

      Assert.Equal(1, actual.Value);
    }

    [Fact]
    public void DivisionOperator_WithValueOfItself_CreatesNewObjectWithValueOne()
    {
      var actual = (UnitOfLength<T>)this._objectToTest / this._objectToTest.Value;

      Assert.Equal(1, actual.Value);
    }

    [Fact]
    public void MultiplyOperator_WithItself_CreatesNewObjectWithDoubleValue()
    {
      var expected = this._objectToTest.Value * this._objectToTest.Value;

      var actual = (UnitOfLength<T>)this._objectToTest * (UnitOfLength<T>)this._objectToTest;

      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void MultiplyOperator_WithValueOfItself_CreatesNewObjectWithDoubleValue()
    {
      var expected = this._objectToTest.Value * this._objectToTest.Value;

      var actual = (UnitOfLength<T>)this._objectToTest * this._objectToTest.Value;

      Assert.Equal(expected, actual.Value);
    }
  }
}

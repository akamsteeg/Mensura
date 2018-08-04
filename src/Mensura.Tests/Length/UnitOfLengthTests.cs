using System;
using Mensura.Length;
using Xunit;

namespace Mensura.Tests.Length
{
  public abstract class UnitOfLengthTests
  {
    protected readonly UnitOfLength _objectToTest;

    protected UnitOfLengthTests(UnitOfLength objectToTest)
    {
      this._objectToTest = objectToTest ?? throw new ArgumentNullException(nameof(objectToTest));
    }

    [Fact]
    public void Add_WithZeroValueToAdd_DoesNotThrow()
    {
      this._objectToTest.Add(0);
    }

    [Fact]
    public void ToSI_ReturnsMetre()
    {
      Assert.IsType<Metre>(this._objectToTest.ToSI());
    }

    [Fact]
    public void Add_NegativeValueToZero_SetsValuePropertyToZero()
    {
      this._objectToTest.Add(-this._objectToTest.Value); // Set value to zero

      this._objectToTest.Add(-100);

      Assert.Equal(0, this._objectToTest.Value);
    }

    [Fact]
    public void Add_One_IncreasesValueWithOne()
    {
      var expectedValue = this._objectToTest.Value + 1;

      this._objectToTest.Add(1);

      Assert.Equal(expectedValue, this._objectToTest.Value);
    }

    [Fact]
    public void Add_ObjectToItself_DoublesValue()
    {
      var expectedValue = this._objectToTest.Value * 2;

      this._objectToTest.Add(this._objectToTest);

      Assert.Equal(expectedValue, this._objectToTest.Value);
    }

    [Fact]
    public void CompareTo_WithSmallerValue_ReturnsPlusOne()
    {
      var testValue = (UnitOfLength)this._objectToTest.Clone();
      testValue.Add(-1);

      var comparisonResult = this._objectToTest.CompareTo(testValue);

      Assert.Equal(1, comparisonResult);
    }

    [Fact]
    public void CompareTo_WithBiggerValue_ReturnsMinusOne()
    {
      var testValue = (UnitOfLength)this._objectToTest.Clone();
      testValue.Add(1);

      var comparisonResult = this._objectToTest.CompareTo(testValue);

      Assert.Equal(-1, comparisonResult);
    }

    [Fact]
    public void CompareTo_WithEqualValue_ReturnsMinusOne()
    {
      var testValue = (UnitOfLength)this._objectToTest.Clone();

      var comparisonResult = this._objectToTest.CompareTo(testValue);

      Assert.Equal(0, comparisonResult);
    }

    [Fact]
    public void Equals_WithItSelf_ReturnsTrue()
    {
      Assert.True(this._objectToTest.Equals(this._objectToTest));
    }

    [Fact]
    public void Equals_WithSameValue_ReturnsTrue()
    {
      var objectToCompareWith = this._objectToTest.Clone();

      Assert.True(this._objectToTest.Equals(objectToCompareWith));
    }

    [Fact]
    public void Equals_WithDifferentValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest.Equals(objectToCompareWith));
    }

    [Fact]
    public void Equals_WithSameValueAsObject_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest.Equals((object)objectToCompareWith));
    }

    [Fact]
    public void Equals_WithDifferentValueAsObject_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest.Equals((object)objectToCompareWith));
    }

    [Fact]
    public void Equals_WithDifferentValueAsIComparable_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest.Equals((IComparable)objectToCompareWith.Value));
    }

    [Fact]
    public void Equals_WithPlainObject_ReturnsFalse()
    {
      var objectToCompareWith = new object();

      Assert.False(this._objectToTest.Equals(objectToCompareWith));
    }

    [Fact]
    public void EqualityOperator_WithSameValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest == objectToCompareWith);
    }

    [Fact]
    public void EqualityOperator_WithSameIComparableValue_ReturnsTrue()
    {
      Assert.True(this._objectToTest == this._objectToTest.Value);
    }

    [Fact]
    public void EqualityOperator_WithDifferentValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest == objectToCompareWith);
    }

    [Fact]
    public void EqualityOperator_WithDifferentIComparableValue_ReturnsFalse()
    {
      Assert.False(this._objectToTest == this._objectToTest.Value + 1);
    }

    [Fact]
    public void NotEqualsOperator_WithSameValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest != objectToCompareWith);
    }

    [Fact]
    public void NotEqualsOperator_WithSameIComparableValue_ReturnsFalse()
    {
      Assert.False(this._objectToTest != this._objectToTest.Value);
    }

    [Fact]
    public void NotEqualsOperator_WithDifferentValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.True(this._objectToTest != objectToCompareWith);
    }

    [Fact]
    public void NotEqualsOperator_WithDifferentIComparableValue_ReturnsFalse()
    {
      Assert.True(this._objectToTest != this._objectToTest.Value + 1);
    }

    [Fact]
    public void LessThanOperator_WithSameValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest < objectToCompareWith);
    }

    [Fact]
    public void LessThanOperator_WithBiggerValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.True(this._objectToTest < objectToCompareWith);
    }

    [Fact]
    public void LessThanOperator_WithSameIComparableValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest < objectToCompareWith.Value);
    }

    [Fact]
    public void LessThanOperator_WithBiggerIComparableValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest < objectToCompareWith.Value + 1);
    }

    [Fact]
    public void GreaterThanOperator_WithSameValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest > objectToCompareWith);
    }

    [Fact]
    public void GreaterThanOperator_WithBiggerValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest > objectToCompareWith);
    }

    [Fact]
    public void GreaterThanOperator_WithSameIComparableValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest > objectToCompareWith.Value);
    }

    [Fact]
    public void GreaterThanOperator_WithBiggerIComparableValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.False(this._objectToTest > objectToCompareWith.Value + 1);
    }

    [Fact]
    public void LessThanOrEqualToOperator_WithSameValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest <= objectToCompareWith);
    }

    [Fact]
    public void LessThanOrEqualToOperator_WithBiggerValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.True(this._objectToTest <= objectToCompareWith);
    }

    [Fact]
    public void LessThanOrEqualToOperator_WithSameIComparableValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest <= objectToCompareWith.Value);
    }

    [Fact]
    public void GreaterThanOrEqualToOperator_WithSameValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest >= objectToCompareWith);
    }

    [Fact]
    public void GreaterThanOrEqualToOperator_WithBiggerValue_ReturnsFalse()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      objectToCompareWith.Add(1);

      Assert.False(this._objectToTest >= objectToCompareWith);
    }

    [Fact]
    public void GreaterThanOrEqualToOperator_WithSameIComparableValue_ReturnsTrue()
    {
      var objectToCompareWith = (UnitOfLength)this._objectToTest.Clone();

      Assert.True(this._objectToTest >= objectToCompareWith.Value);
    }
  }
}

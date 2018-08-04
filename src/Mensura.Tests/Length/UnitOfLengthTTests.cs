using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensura.Length;

namespace Mensura.Tests.Length
{
  public abstract class UnitOfLengthTTests<T>
    : UnitOfLengthTests
    where T: UnitOfLength
  {
    protected UnitOfLengthTTests(T objectToTest)
      : base(objectToTest)
    {
    }
  }
}

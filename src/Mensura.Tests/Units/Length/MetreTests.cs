using Mensura.Units.Length;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensura.Tests.Units.Length
{
    [TestFixture]
    class MetreTests
    {
        [Test]       
        public void NewMetreDouble_Successful([Values(double.MinValue, 0.0, 1.0, double.MaxValue)] double value)
        {
            var m = new Metre(value);

            Assert.IsNotNull(m);
        }

        [Test]
        public void NewMetreInt_Successful([Values(int.MinValue, 0, 1, int.MaxValue)] int value)
        {
            var m = new Metre(value);

            Assert.IsNotNull(m);
        }

        [Test]
        public void FromNanometresDouble([Values(double.MinValue, 0.0, 1.0, double.MaxValue)] double value)
        {
            var m = Metre.FromNanometres(value);

            double expected = value * 1000000000;

            Assert.AreEqual(expected, m.Value);
        }

        [Test]
        public void FromNanometresInt([Values(int.MinValue, 0, 1, int.MaxValue)] int value)
        {
            var m = Metre.FromNanometres(value);

            double expected = value * 1000000000;

            Assert.AreEqual(expected, m.Value);
        }

        [Test]
        public void FromMicrometresDouble([Values(double.MinValue, 0.0, 1.0, double.MaxValue)] double value)
        {
            var m = Metre.FromMicrometres(value);

            double expected = value * 1000000;

            Assert.AreEqual(expected, m.Value);
        }

        [Test]
        public void FromMicrometresInt([Values(int.MinValue, 0, 1, int.MaxValue)] int value)
        {
            var m = Metre.FromMicrometres(value);

            double expected = value * 1000000;

            Assert.AreEqual(expected, m.Value);
        }

        [Test]
        public void FromMillimetresDouble([Values(double.MinValue, 0.0, 1.0, double.MaxValue)] double value)
        {
            var m = Metre.FromMillimetres(value);

            double expected = value * 1000;

            Assert.AreEqual(expected, m.Value);
        }

        [Test]
        public void FromMilliometresInt([Values(int.MinValue, 0, 1, int.MaxValue)] int value)
        {
            var m = Metre.FromMillimetres(value);

            double expected = value * 1000;

            Assert.AreEqual(expected, m.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensura.Units.Length
{
    /// <summary>
    /// 
    /// </summary>
    public class Metre : Length
    {
        /// <summary>
        /// Nanometres per meter
        /// </summary>
        protected const int NanometresPerMeter = 1000000000;
        /// <summary>
        /// Micrometres per meter
        /// </summary>
        protected const int MicrometresPerMeter = 1000000;
        /// <summary>
        /// Milimetres per meter
        /// </summary>
        protected const int MillimetrersPerMeter = 1000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Metre(int value)
            : base(value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Metre(double value)
            : base(value)
        {
        }

        #region factory methods
        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in nanometres
        /// </summary>
        /// <param name="value">
        /// The value, in nanometres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromNanometres(double value)
        {
            double valueInMetres = value * NanometresPerMeter;

            return CreateInstance(valueInMetres);
        }

        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in nanometres
        /// </summary>
        /// <param name="value">
        /// The value, in nanometres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromNanometres(int value) => 
            FromNanometres((double)value);

        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in micrometres
        /// </summary>
        /// <param name="value">
        /// The value, in micrometres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromMicrometres(double value)
        {
            double valueInMetres = value * MicrometresPerMeter;

            return CreateInstance(valueInMetres);
        }

        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in micrometers
        /// </summary>
        /// <param name="value">
        /// The value, in micrometers
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromMicrometres(int value) =>
            FromMicrometres((double)value);

        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in millimetres
        /// </summary>
        /// <param name="value">
        /// The value, in millimetres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromMillimetres(double value)
        {
            double valueInMetres = value * MillimetrersPerMeter;

            return CreateInstance(valueInMetres);
        }

        /// <summary>
        /// Create a new instance of <see cref="Metre"/>, from
        /// a value in millimetres
        /// </summary>
        /// <param name="value">
        /// The value, in millimetres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// with the specified value
        /// </returns>
        public static Metre FromMillimetres(int value) =>
            FromMillimetres((double)value);

        #endregion factory methods

        /// <summary>
        /// Get the value in nanometres
        /// </summary>
        /// <returns></returns>
        public double ToNanometres() =>
            this.Value / NanometresPerMeter;

        /// <summary>
        /// Get the value in micrometres
        /// </summary>
        /// <returns></returns>
        public double ToMicrometres() =>
            this.Value / MicrometresPerMeter;

        /// <summary>
        /// Get the value in milimetres
        /// </summary>
        /// <returns></returns>
        public double ToMillimetres() =>
            this.Value / MillimetrersPerMeter;

        /// <summary>
        /// Create a new instance
        /// of <see cref="Metre"/> 
        /// with the specified value
        /// </summary>
        /// <param name="value">
        /// The value, in metres
        /// </param>
        /// <returns>
        /// A new instance of <see cref="Metre"/>
        /// </returns>
        private static Metre CreateInstance(double value)
        {
            var result = new Metre(value);
            return result;
        }
    }
}

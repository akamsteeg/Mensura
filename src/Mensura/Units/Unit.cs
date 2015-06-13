using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensura.Units
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Unit
    {
        /// <summary>
        /// 
        /// </summary>
        protected double Value
        {
            get; // Auto-implemented readonly property
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        protected Unit(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        protected Unit(double value)
        {
            this.Value = value;
        }

    }
}

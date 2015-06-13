using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensura.Units.Length
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Length : Unit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        protected Length(int value)
            : base(value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        protected Length(double value)
            : base(value)
        {
        }
    }
}

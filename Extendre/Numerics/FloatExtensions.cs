using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extendre.Numerics
{
    /// <summary>
    /// Provides extension methods for 16 bit floating point numbers.
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        /// Determine whether a number is within a particular range.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="low">The low end of the range.</param>
        /// <param name="high">The high end of the range.</param>
        /// <returns>True if the number is in the range, False otherwise.</returns>
        public static bool InRange(this float num, double low, double high)
        {
            return (num >= low && num <= high) ? true : false;
        }
    }
}

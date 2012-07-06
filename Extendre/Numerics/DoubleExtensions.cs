using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Provides extension methods for 64 bit floating point numbers.
/// </summary>
public static class DoubleExtensions
{

    /// <summary>
    /// Determine whether a number is within a particular range.
    /// </summary>
    /// <param name="num">The number.</param>
    /// <param name="low">The low end of the range.</param>
    /// <param name="high">The high end of the range.</param>
    /// <returns>True if the number is in the range, False otherwise.</returns>
    public static bool InRange(this double num, double low, double high)
    {
        return (num >= low && num <= high) ? true : false;
    }

    /// <summary>
    /// Get the square root of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The square root of the given number.</returns>
    public static Double SqaureRoot(this Double value)
    {
        return Math.Sqrt(value);
    }

    /// <summary>
    /// Get the absolute value of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The absolute value of the given number.</returns>
    public static Double AbsoluteValue(this Double value)
    {
        return Math.Abs(value);
    }

    /// <summary>
    /// Get the given number raised to a given power.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <param name="exponent">The given power.</param>
    /// <returns>The given number raised to a given power.</returns>
    public static Double Pow(this Double value, Double exponent)
    {
        return Math.Pow(value, exponent);
    }
}


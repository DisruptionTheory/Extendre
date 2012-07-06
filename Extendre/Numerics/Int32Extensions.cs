using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// Provides extension methods for 32 bit integers.
/// </summary>
public static class Int32Extensions {

    /// <summary>
    /// Convert the given Int32 number to an Int64.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>The given number as an Int64 value.</returns>
    public static Int64 ToInt64(this Int32 num) {
        return num;
    }

    /// <summary>
    /// Calculates the factorial of a given number.
    /// </summary>
    /// <remarks>
    /// Requires reference to System.Numerics
    /// </remarks>
    /// <param name="num">The number for which to compute the factorial.</param>
    /// <returns>The computed factorial as a Big Integer. This function will return -1 if the input number is negative.</returns>
    public static BigInteger Factorial(this Int32 num) {
        return num.ToInt64().Factorial();
    }

    /// <summary>
    /// Calculate the prime factors of a given number.
    /// </summary>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>An array of the prime factors of a given number.</returns>
    public static Int32[] PrimeFactors(this Int32 num)
    {
        long[] bigFactors = num.ToInt64().PrimeFactors();
        int[] intFactors = new int[bigFactors.Length];
        for (int i = 0; i <= intFactors.Length; i++) {
            intFactors[i] = (int)bigFactors[i];
        }
        return intFactors;
    }

    /// <summary>
    /// Calculates the prime number that is greater than and closest to the given number.
    /// </summary>
    /// /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>The next prime.</returns>
    public static Int64 NextPrime(this Int32 num)
    {
        return num.ToInt64().NextPrime();
    }

    /// <summary>
    /// Determine if the given number is prime.
    /// </summary>
    /// <param name="num">The number to determine if is prime.</param>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <returns>True if prime, false if not.</returns>
    public static bool IsPrime(this Int32 num)
    {
        return num.ToInt64().IsPrime();
    }

    /// <summary>
    /// Checks if the given number is in the specified range.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <param name="low">The low value of the range.</param>
    /// <param name="high">The high value of the range.</param>
    /// <returns>True if number is in range, false otherwise.</returns>
    public static bool InRange(this Int32 num, Int64 low, Int64 high) {
        return num.ToInt64().InRange(low, high);
    }

    /// <summary>
    /// Checks if the given number is even.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if even, false otherwise.</returns>
    public static bool IsEven(this Int32 num) {
        return num % 2 == 0;
    }


    /// <summary>
    /// Checks if the given number is odd.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if odd, false otherwise.</returns>
    public static bool IsOdd(this Int32 value) {
        return value % 2 != 0;
    }

    /// <summary>
    /// Get the square root of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The square root of the given number.</returns>
    public static Double SqaureRoot(this Int32 value)
    {
        return Math.Sqrt(value);
    }

    /// <summary>
    /// Get the absolute value of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The absolute value of the given number.</returns>
    public static Int32 AbsoluteValue(this Int32 value)
    {
        return Math.Abs(value);
    }

    /// <summary>
    /// Get the given number raised to a given power.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <param name="exponent">The given power.</param>
    /// <returns>The given number raised to a given power.</returns>
    public static Double Pow(this Int32 value, double exponent)
    {
        return Math.Pow(value, exponent);
    }
        

}

using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// Provides extension methods for 16 bit integers.
/// </summary>
public static class Int16Extensions
{
    /// <summary>
    /// Convert the given Int16 number to an Int64.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>The given number as an Int64 value.</returns>
    public static Int64 ToInt64(this Int16 num) {
        return num;
    }

    /// <summary>
    /// Convert the given Int16 number to an Int64.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>The given number as an Int64 value.</returns>
    public static Int32 ToInt32(this Int16 num) {
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
    public static BigInteger Factorial(this Int16 num)
    {
        return num.ToInt32().Factorial();
    }

    /// <summary>
    /// Determine if the given number is prime.
    /// </summary>
    /// <param name="num">The number to determine if is prime.</param>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <returns>True if prime, false if not.</returns>
    public static bool IsPrime(this Int16 num)
    {
        return num.ToInt32().IsPrime();
    }

    /// <summary>
    /// Calculates the prime number that is greater than and closest to the given number.
    /// </summary>
    /// /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>The next prime.</returns>
    public static Int64 NextPrime(this Int16 num)
    {
        return num.ToInt32().NextPrime();
    }

    /// <summary>
    /// Calculate the prime factors of a given number.
    /// </summary>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>An array of the prime factors of a given number.</returns>
    public static Int16[] PrimeFactors(this Int16 num)
    {
        long[] bigFactors = num.ToInt64().PrimeFactors();
        short[] intFactors = new short[bigFactors.Length];
        for (int i = 0; i <= intFactors.Length; i++) {
            intFactors[i] = (short)bigFactors[i];
        }
        return intFactors;
    }

    /// <summary>
    /// Checks if the given number is in the specified range.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <param name="low">The low value of the range.</param>
    /// <param name="high">The high value of the range.</param>
    /// <returns>True if number is in range, false otherwise.</returns>
    public static bool InRange(this Int16 num, Int64 low, Int64 high) {
        return num.ToInt32().InRange(low, high);
    }

    /// <summary>
    /// Checks if the given number is even.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if even, false otherwise.</returns>
    public static bool IsEven(this Int16 num) {
        return num % 2 == 0;
    }


    /// <summary>
    /// Checks if the given number is odd.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if odd, false otherwise.</returns>
    public static bool IsOdd(this Int16 value) {
        return value % 2 != 0;
    }

}


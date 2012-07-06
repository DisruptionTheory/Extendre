using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// Provides extension methods for 64 bit integers.
/// </summary>
public static class Int64Extensions
{

    /// <summary>
    /// Calculates the factorial of a given number.
    /// </summary>
    /// <remarks>
    /// Requires reference to System.Numerics.
    /// This will take a LONG time for extremely large numbers.
    /// </remarks>
    /// <param name="num">The number for which to compute the factorial.</param>
    /// <returns>The computed factorial as a Big Integer. This function will return -1 if the input number is negative.</returns>
    public static BigInteger Factorial(this Int64 num)
    {
        if (num < 0) return -1;
        if (num == 0 || num == 1) return 1;
        BigInteger fact = num;
        for (long i = num - 1; i >= 1; i--)
        {
            fact *= i;
        }
        return fact;
    }

    /// <summary>
    /// Determine if the given number is prime.
    /// </summary>
    /// <param name="num">The number to determine if is prime.</param>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <returns>True if prime, false if not.</returns>
    public static bool IsPrime(this Int64 num)
    {
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    /// <summary>
    /// Calculates the prime number that is greater than and closest to the given number.
    /// </summary>
    /// /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>The next prime.</returns>
    public static Int64 NextPrime(this Int64 num)
    {
        long next = num + 1;
        while (true)
        {
            if (next.IsPrime()) return next;
            next += 1;
        }
    }

    /// <summary>
    /// Calculate the prime factors of a given number.
    /// </summary>
    /// <remarks>This function could take a long time for large numbers.</remarks>
    /// <param name="num">The given number.</param>
    /// <returns>An array of the prime factors of a given number.</returns>
    public static Int64[] PrimeFactors(this Int64 num)
    {
        //check if the number is prime first
        if (num.IsPrime()) return new Int64[] { num };

        List<long> primeFactors = new List<long>();
        long value = num;
        long prime = 1;
        while (true)
        {
            prime = prime.NextPrime();
            while (value % prime == 0)
            {
                value /= prime;
                primeFactors.Add(prime);
            }

            if (value == 1)
                break;
        }
        return primeFactors.ToArray();
    }

    /// <summary>
    /// Checks if the given number is in the specified range.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <param name="low">The low value of the range.</param>
    /// <param name="high">The high value of the range.</param>
    /// <returns>True if number is in range, false otherwise.</returns>
    public static bool InRange(this Int64 num, Int64 low, Int64 high) {
        if (num >= low && num <= high) return true;
        return false;
    }

    /// <summary>
    /// Checks if the given number is even.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if even, false otherwise.</returns>
    public static bool IsEven(this Int64 num) {
        return num % 2 == 0;
    }


    /// <summary>
    /// Checks if the given number is odd.
    /// </summary>
    /// <param name="num">The given number.</param>
    /// <returns>True if odd, false otherwise.</returns>
    public static bool IsOdd(this Int64 value) {
        return value % 2 != 0;
    }

    /// <summary>
    /// Get the square root of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The square root of the given number.</returns>
    public static Double SqaureRoot(this Int64 value)
    {
        return Math.Sqrt(value);   
    }

    /// <summary>
    /// Get the absolute value of the given number.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <returns>The absolute value of the given number.</returns>
    public static Int64 AbsoluteValue(this Int64 value)
    {
        return Math.Abs(value);
    }

    /// <summary>
    /// Get the given number raised to a given power.
    /// </summary>
    /// <param name="value">The given number.</param>
    /// <param name="exponent">The given power.</param>
    /// <returns>The given number raised to a given power.</returns>
    public static Double Pow(this Int64 value, double exponent)
    {
        return Math.Pow(value, exponent);
    }
}

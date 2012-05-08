using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Extension methods for strings and text.
/// </summary>
public static class StringExtensions {

    /// <summary>
    /// Get the number of words in a given string.
    /// </summary>
    /// <param name="text">The string to check in.</param>
    /// <returns>The number of words in the string.</returns>
    public static int WordCount(this string text) {
        return text.Split(new char[] { ' ', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    /// <summary>
    /// Randomizes the order of the characters in the given string.
    /// </summary>
    /// <param name="text">The string to randomize.</param>
    /// <returns>The randomized string.</returns>
    public static string Randomize(this string text){
        char[] unrandomized = text.ToCharArray();
        List<Tuple<int, char>> valueList = new List<Tuple<int, char>>();
        Random randomizer = new Random();
        foreach (char current in unrandomized){
            valueList.Add(new Tuple<int, char>(randomizer.Next(), current));
        }
        valueList.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        StringBuilder randomized = new StringBuilder();
        foreach (Tuple<int, char> current in valueList)
        {
            randomized.Append(current.Item2);
        }
        return randomized.ToString();
    }

    /// <summary>
    /// Places all characters in ascending character value order.
    /// The sort is on the numeric character value of the characters in the text.
    /// </summary>
    /// <param name="text">The given string to sort.</param>
    /// <returns>A sorted string.</returns>
    public static string Sort(this string text)
    {
        List<char> sortList = new List<char>(text.ToCharArray());
        sortList.Sort((a, b) => a.CompareTo(b));
        string sorted = "";
        foreach (char current in sortList)
        {
            sorted += current;
        }
        return sorted;
    }

    /// <summary>
    /// Reverse the given string.
    /// </summary>
    /// <param name="text">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    public static string Reverse(this string text)
    {
        char[] reversed = text.ToCharArray().Reverse();
        return reversed.Flatten();
    }

}


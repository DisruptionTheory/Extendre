using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extendre.Collections
{
    public static class CharArrayExtensions
    {

        /// <summary>
        /// Convert the character array sequence into a string of characters.
        /// </summary>
        /// <param name="sequence">The character array to flatten.</param>
        /// <returns>The string of characters in the array.</returns>
        public static string Flatten(this char[] sequence)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(sequence);
            return builder.ToString();
        }
    }
}

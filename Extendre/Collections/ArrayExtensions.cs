using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extendre.Numerics;


namespace Extendre.Collections
{
    /// <summary>
    /// Provides extension methods for Arrays.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Reverses the order of the elements in the given array.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to be reversed.</param>
        /// <returns>The reversed array.</returns>
        public static T[] Reverse<T>(this T[] array){
            if (array.Length.IsEven())
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    array = array.SwapElements(i, array.Length - i - 1);
                }
                return array;
            }
            else
            {
                for (int i = 0; i < (array.Length - 1) / 2; i++)
                {
                    array = array.SwapElements(i, array.Length - i - 1);
                }
                return array;
            }
        }

        /// <summary>
        /// Swaps two elements in the given array.
        /// </summary>
        /// <typeparam name="T">The type of the given array.</typeparam>
        /// <param name="array">The given array.</param>
        /// <param name="firstElementIndex">The index of the first elements to be swapped.</param>
        /// <param name="secondElementIndex">The index of the second element to be swapped.</param>
        /// <returns>The array with the two elements swapped.</returns>
        public static T[] SwapElements<T>(this T[] array, int firstElementIndex, int secondElementIndex)
        {
            T element1 = array[firstElementIndex];
            T element2 = array[secondElementIndex];
            array[firstElementIndex] = element2;
            array[secondElementIndex] = element1;
            return array;
        }

        /// <summary>
        /// Sets each element in the array to the default constructed value for the type.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to clear.</param>
        /// <returns>The cleared array.</returns>
        public static T[] Clear<T>(this T[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                array[i] = default(T);
            }
            return array;
        }

        /// <summary>
        /// Removes every instance of a specified item from the array.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to remove from.</param>
        /// <param name="item">The item to remove.</param>
        /// <returns>The cleaned array.</returns>
        public static T[] Remove<T>(this T[] array, T item)
        {
            List<T> newCollection = new List<T>();
            for (int i = 0; i <= array.Length; i++)
            {
                if(!array[i].Equals(item))
                    newCollection.Add(array[i]);
            }
            return newCollection.ToArray();
        }

        /// <summary>
        /// Removes the first instance of a specified item from the array.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to remove from.</param>
        /// <param name="item">The item to remove.</param>
        /// <returns>The cleaned array.</returns>
        public static T[] RemoveOnce<T>(this T[] array, T item)
        {
            List<T> newCollection = new List<T>();
            for (int i = 0; i <= array.Length; i++)
            {
                if (!array[i].Equals(item))
                {
                    newCollection.Add(array[i]);
                }
                else
                {
                    newCollection.AddRange(array.GetAfter(i + 1));
                    return newCollection.ToArray();
                }
            }
            return newCollection.ToArray();
        }

        /// <summary>
        /// Get the array of all elements after and including the specified index.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to retrieve the values from.</param>
        /// <param name="index">The index to start from.</param>
        /// <returns>An array of all elements including and after the specified index.</returns>
        public static T[] GetAfter<T>(this T[] array, int index)
        {
            T[] newArray = new T[array.Length - index];
            for (int i = index, j = 0; i < array.Length; i++, j++)
            {
                newArray[j] = array[i];
            }
            return newArray;            
        }

        /// <summary>
        /// Get the array of all elements before the specefied index.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to retrieve the values from.</param>
        /// <param name="index">The index to end at.</param>
        /// <returns>An array of all values before the specified index.</returns>
        public static T[] GetBefore<T>(this T[] array, int index)
        {
            T[] newArray = new T[index];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Get a section of the given array specefied by the lower and upper bounds.
        /// Both the lower and upper bounds will be included in the cut section.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to cut.</param>
        /// <param name="lowerBound">The lower bound of the section.</param>
        /// <param name="upperBound">The upper bound of the section.</param>
        /// <returns>The specefied section of the array.</returns>
        public static T[] GetSection<T>(this T[] array, int lowerBound, int upperBound)
        {
            T[] newArray = new T[array.Length - (upperBound - lowerBound)];
            for (int i = lowerBound, j = 0; i <= upperBound; i++, j++)
            {
                newArray[j] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Get a random value from the array.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to get the value from.</param>
        /// <returns>A random value pulled from the array.</returns>
        public static T GetRandom<T>(this T[] array)
        {
            Random randomizer = new Random();
            int randomNum = randomizer.Next(array.Length);
            return array[randomNum];
        }
    }
}

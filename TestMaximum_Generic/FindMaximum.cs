// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindMaximum.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace TestMaximum_Generic
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class FindMaximum
    {
        /// <summary>
        /// UC 1 : Finds Maximum the integer among three.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public static int MaxIntegerAmongThree(int firstValue, int secondValue, int thirdValue)
        {
            Console.WriteLine("Maximum number among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            /// Checks if firstValue is great then both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            /// Checks if secondValue is great then both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else
                return thirdValue;
        }
        /// <summary>
        /// UC 2 : Finds Maximum float value among three.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public static double MaxFloatAmongThree(double firstValue, double secondValue, double thirdValue)
        {
            Console.WriteLine("Maximum number among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            /// Checks if firstValue is great then both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            /// Checks if secondValue is great then both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else
                return thirdValue;
        }
        /// <summary>
        /// UC3: Finds maximum string value among three
        /// </summary>
        /// <param name="firstString">The first value.</param>
        /// <param name="secondString">The second value.</param>
        /// <param name="thirdString">The third value.</param>
        /// <returns></returns>
        public static string MaxStringtAmongThree(string firstString, string secondString, string thirdString)
        {
            Console.WriteLine("Maximum string among {0}, {1} and {2}: ", firstString, secondString, thirdString);
            /// Checks if firstValue is great then both secondValue and thirdValue
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
                return firstString;
            /// Checks if secondValue is great then both firstValue and thirdValue
            else if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
                return secondString;
            else
                return thirdString;
        }
    }
}
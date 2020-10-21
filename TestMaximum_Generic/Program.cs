// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace TestMaximum_Generic
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            /// Finds max among the given three data
            Console.WriteLine(FindMaximum.MaxIntegerAmongThree(10, 20, 30));
            /// UC 2 : Finds the max float value among three
            Console.WriteLine(FindMaximum.MaxFloatAmongThree(6.897, 7.085, 5.8789));
            /// UC3: Finds the max string vlaue among three
            Console.WriteLine(FindMaximum.MaxStringtAmongThree("Nolan", "SpielBerg", "Martin"));
        }
    }
}

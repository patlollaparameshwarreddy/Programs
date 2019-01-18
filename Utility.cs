//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used for declaring repeated task
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets the integer will return the integer value
        /// </summary>
        /// <returns>integer required by the programmer</returns>
        public static int GetInt()
        {
            ////converting string to integer
            int integer = Convert.ToInt32(Console.ReadLine());
            return integer;
        }

        /// <summary>
        /// get double will return the double value
        /// </summary>
        /// <returns>returns double value required by the programmer</returns>
        public static double GetDouble()
        {
            ////string id converted to double
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }
    }
}

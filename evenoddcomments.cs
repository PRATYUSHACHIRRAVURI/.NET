using System;

namespace FirstProject
{
    /// <summary>
    /// The main EvenOdd class.
    /// Contain methods for performing basic even odd function.
    /// </summary>
    /// <remarks>
    /// This class can find out even odd digit.
    /// </remarks>
    /// <list>
    /// <item>
    /// <term>Even</term>
    /// <description>Even Operation</description>
    /// </item>
    /// <item>
    /// <term>Odd</term>
    /// <description>Odd Operation</description>
    /// </item>
    class EvenOdd
    {
        //This program is to check whether a given digit is even and odd
        /// <remarks>
        /// This operations can be performed on only integers
        /// </remarks>
        /// <example>
        /// <code>
        /// int i = 5;
        /// if (i%2 == 0)
        /// {
        ///     Even();
        ///   else
        ///     Odd();
        /// </code>
        /// </example>
        static void Main(string[] args)
        {
            //Intialize a variable
            int i;
            Console.WriteLine("Enter a digit:");
            //read the input and convert it into integer using parse
            /// <value>Gets the value of i.</value>
            i = int.Parse(Console.ReadLine());
            //check whether the digit is giving 0 as output when divided by 2
            if (i % 2 == 0)
                //If yes calls even function
                Even();
            else
                //IF no calls odd function
                Odd();


        }
        /// <summary>
        ///Even prints even on the console.
        /// </summary>
        /// <returns>
        /// Nothing.
        /// </returns>
        /// See <see cref="EvenOdd.Odd()"/> to find out odd function.
        public static void Even()
        {
            //It prints Even to the console
            Console.WriteLine("Digit is EVEN");
        }
        /// <summary>
        ///Odd prints odd on the console.
        /// </summary>
        /// <returns>
        /// Nothing.
        /// </returns>
        public static void Odd()
        {
            //It prints Odd to the console
            Console.WriteLine("Digit is ODD");
        }
    }
}

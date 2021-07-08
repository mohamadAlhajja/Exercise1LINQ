using System.Collections.Generic;
using System.Linq;

namespace Exercise1LINQ
{
    public class FullExercise1
    {
        // The following method should return true if each element in the squares sequence
        // is equal to the square of the corresponding element in the numbers sequence.
        // Try to write the entire method using only LINQ method calls, and without writing
        // any loops.
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            IEnumerable<int> query = numbers.Select(val => val * val);
            bool isEqual = squares.SequenceEqual(query);

            return isEqual;
        }
        static void Main(string[] args)
        {
            IEnumerable<int> n = new List<int> { 2, 5, 4, 6 };
            IEnumerable<int> nn = new List<int> { 4, 25, 16, 36 };
            
            System.Console.WriteLine(TestForSquares(n, nn));
        }

    }
   
}

    
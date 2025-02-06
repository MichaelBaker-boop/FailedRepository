// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int listingType;
            Console.WriteLine("Welcome to the Inventory Management Application.\n");
            Console.Write("Would you like to use arrays or lists (1 or 2)?");
            listingType = int.Parse(Console.ReadLine());
        }
    }
}

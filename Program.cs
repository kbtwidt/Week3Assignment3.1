using System.Text;

namespace Week3Assignment3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Console.WriteLine("Part 1");
            Console.WriteLine("Displaying even numbers 1-100");

            StringBuilder evenNumbers = new StringBuilder();

            ReturnEvenNumbers(out evenNumbers);

            Console.WriteLine("\n" + evenNumbers);

            #endregion

            #region Part 2
            Console.WriteLine("\nPart 2");
            int year;
            char choice = 'y';

            while (choice == 'y')
            {
                Console.Write("Enter a year to determine if it is a leap year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Leap: " + IfYearIsLeap(year));
                Console.Write("\nWould you like to enter another year (y/n): ");
                choice = Convert.ToChar(Console.ReadLine().ToLower());
            }

            #endregion

            #region Part 3
            Console.WriteLine("\nPart 3");
            string userString;
            Console.WriteLine("Enter a sentence: ");
            userString = Console.ReadLine();
            Console.WriteLine($"\"{userString}\" contains {NumberSpaces(userString)} spaces.");

            #endregion

            #region Part 4
            Console.WriteLine("\nPart 4");

            int arraySize;
            Console.Write("\nHow many numbers in the array?: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[arraySize];
            Console.Write($"Enter {arraySize} numbers separated by commas: ");
            string[] inputArray = Console.ReadLine().Split(',');

            for (int i = 0; i < arraySize; i++)
            {
                userArray[i] = Convert.ToInt32(inputArray[i].Trim());
            }

            userArray = ArrayParse(userArray);

            Console.WriteLine("\nArray after parsing for first 1, 1 pair altered: ");
            foreach (int i in userArray)
            {
                Console.Write(i + ", ");
            }

            #endregion        
        }

        static void ReturnEvenNumbers(out StringBuilder evenNumbers)
        {
            evenNumbers = new StringBuilder();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Append(i.ToString() + " ");
                }
            }
        }

        static bool IfYearIsLeap(int year)
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }

        static int NumberSpaces(string s)
        {
            int spacesCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    spacesCounter++;
                }
            }

            return spacesCounter;
        }

        static int[] ArrayParse(int[] args)
        {
            for (int i = 0; i <= args.Length; i++)
            {
                if (args[i] == 1 && args[i+1] == 1)
                {
                    args[i] = 0;
                    args[i+1] = 0;
                    break;
                }
            }
            return args;
        }
    }
}

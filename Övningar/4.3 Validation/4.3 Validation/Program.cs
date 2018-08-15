using System;

namespace _4._3_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = AskUserForSeparator();
            bool error = AskUserForErrorMessage();

            string[] list;

            while (true)
            {

                string names = GetInputFromUser();
                list = CreateArrayOfPeople(names, separator);
                CleanUpArray(list);

                if (PeopleArrayIsValid(list, error))
                    break;


            }

            RespondToUser(list);



        }

        static char AskUserForSeparator()
        {
            Console.WriteLine("Which separator do you want to use? (default is comma) ");
            char separator = char.Parse(Console.ReadLine());
            return separator;

        }
        static bool AskUserForErrorMessage()
        {
            Console.WriteLine("Do you want to see error messages? Yes/No ");
            string error = Console.ReadLine().ToUpper().Trim();

            if (error == "YES")
                return true;
            else
                return false;


        }

        static string GetInputFromUser()
        {
            Console.WriteLine("Enter the names separated by comma: ");
            string names = Console.ReadLine();

            return names;

        }

        static void CleanUpArray(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i].Trim();
            }

        }

        static string[] CreateArrayOfPeople(string names, char separator)
        {
            string[] nameList = names.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
            return nameList;

        }

        static void RespondToUser(string[] peopleArray)
        {
            foreach (var item in peopleArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***SUPER-" + item.ToUpper() + "***");
            }

        }

        private static bool PeopleArrayIsValid(string[] peopleArray, bool error)
        {
            if (peopleArray.Length == 0)
            {
                if (error == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The list don't contain any names");
                    Console.ForegroundColor = ConsoleColor.Gray;
                        }
                return false;
            }

            foreach (string person in peopleArray)
            {
                if (person.Length <= 1 || person.Length >= 10)
                {
                    if (error == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A person can only have 2 to 9 letters");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    return false;
                }
            }
            return true;
        }
    }
}

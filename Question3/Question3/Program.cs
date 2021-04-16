using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question №3");

            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                Console.Write("Enter array elements: ");

                int arrayElements = int.Parse(Console.ReadLine());
                int[] myArray = new int[arrayElements];

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"Enter {i} index, array number: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

                int minIndex = myArray[0];
                int index = -1;

                for (int i = 1; i < myArray.Length; i++)
                {
                    if (myArray[i] < minIndex)
                    {
                        minIndex = myArray[i];
                        index = i;
                    }
                }

                Console.WriteLine($"Result min index from array: {index} (number {minIndex})");
                Console.Write("\nWould you try again ? (Y/y) or (N/n): ");
                do
                {
                    char symbolForSwitch = Convert.ToChar(Console.ReadLine());
                    switch (symbolForSwitch)
                    {
                        case 'Y':
                            {
                                selection = true;
                                selectionForSwitch = true;
                                break;
                            }
                        case 'y':
                            {
                                selection = true;
                                selectionForSwitch = true;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selectionForSwitch = true;
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selectionForSwitch = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selectionForSwitch = false;
                                selection = true;
                                continue;
                            }
                    }
                }
                while (selectionForSwitch == false);
            }
            while (selection == true);

            Console.ReadKey();
        }
    }
}

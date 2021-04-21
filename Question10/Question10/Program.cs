using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Question №9");

                bool selection = true;
                bool selectionForSwitch = false;

                do
                {
                    Console.Write("Enter array elements for Fibonacci: ");

                    int arrayElements = int.Parse(Console.ReadLine());
                    int[] myArray = new int[arrayElements];

                    myArray[0] = 0;
                    myArray[1] = 1;

                    for (int i = 2; i < myArray.Length; i++)
                    {
                        myArray[i] = myArray[i - 1] + myArray[i - 2];
                        Console.WriteLine($"{myArray[i]}");
                    }

                    Console.Write("\nWould you try again ? (Y/y) or (N/n): ");
                    do
                    {
                        string symbolForSwitch = Convert.ToString(Console.ReadLine());
                        switch (symbolForSwitch)
                        {
                            case "Y":
                                {
                                    selection = true;
                                    selectionForSwitch = true;
                                    break;
                                }
                            case "y":
                                {
                                    selection = true;
                                    selectionForSwitch = true;
                                    break;
                                }
                            case "N":
                                {
                                    Console.WriteLine("Have a good day :)");
                                    selection = false;
                                    selectionForSwitch = true;
                                    break;
                                }
                            case "n":
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
}
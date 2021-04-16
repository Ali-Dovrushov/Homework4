﻿using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question №2");

            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                Console.Write("Enter array elements: ");

                int arrayElements = int.Parse(Console.ReadLine());
                int[] myArray = new int[arrayElements];
                int maxElement = myArray[0];

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"Enter {i} index, array number: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > maxElement)
                    {
                        maxElement = myArray[i];
                    }
                }
                Console.WriteLine($"Result max element from array: {maxElement}");
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

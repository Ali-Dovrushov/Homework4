using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question №8");

            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                Console.Write("Enter array elements: ");

                int arrayElements = int.Parse(Console.ReadLine());
                int[] firstMyArray = new int[arrayElements];
                int[] secondMyArray = new int[arrayElements];
                int counter = 0;
                int checkerForOddEvenArray = 1;

                for (int i = 0; i < firstMyArray.Length; i++)
                {
                    Console.Write($"Enter {i} index, array number: ");
                    firstMyArray[i] = int.Parse(Console.ReadLine());
                }

                if (firstMyArray.Length % 2 != 0)
                {
                    checkerForOddEvenArray = 1;
                    for (int i = 0; i < firstMyArray.Length; i++)
                    {
                        if (i < firstMyArray.Length / 2)
                        {
                            secondMyArray[firstMyArray.Length / 2 + checkerForOddEvenArray] = firstMyArray[i];
                            checkerForOddEvenArray++;
                        }
                        else if (i > firstMyArray.Length / 2)
                        {
                            secondMyArray[counter] = firstMyArray[i];
                            counter++;
                        }
                        else
                        {
                            secondMyArray[i] = firstMyArray[i];
                        }
                    }
                }

                else if (firstMyArray.Length % 2 == 0)
                {
                    checkerForOddEvenArray = 0;
                    for (int i = 0; i < firstMyArray.Length; i++)
                    {
                        if (i < firstMyArray.Length / 2)
                        {
                            secondMyArray[firstMyArray.Length / 2 + checkerForOddEvenArray] = firstMyArray[i];
                            checkerForOddEvenArray++;
                        }
                        else if (i > firstMyArray.Length / 2 - 1)
                        {
                            secondMyArray[counter] = firstMyArray[i];
                            counter++;
                        }
                        else if (i == firstMyArray.Length / 2 + 1)
                        {
                            secondMyArray[i] = firstMyArray[i];
                        }
                    }
                }

                foreach (int elem in secondMyArray)
                {
                    Console.WriteLine(elem);
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
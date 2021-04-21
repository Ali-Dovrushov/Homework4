using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Question №9");

                bool selection = true;
                bool checkerForBubble = true;
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

                    for (int i = 0; (i < myArray.Length) && checkerForBubble; i++)
                    {
                        checkerForBubble = false;
                        for (int j = 0; j < myArray.Length - 1; j++)
                        {
                            if (myArray[j + 1] < myArray[j])
                            {
                                int overflow = myArray[j];
                                myArray[j] = myArray[j + 1];
                                myArray[j + 1] = overflow;
                                checkerForBubble = true;
                            }
                        }

                        Console.WriteLine($"\n\nStep{i+1}");

                        for (int k = 0; k < myArray.Length; k++)
                        {
                            Console.Write($"{myArray[k]} ");
                        }
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

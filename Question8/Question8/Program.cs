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

                for (int i = 0; i < firstMyArray.Length; i++)
                {
                    Console.Write($"Enter {i} index, array number: ");
                    firstMyArray[i] = int.Parse(Console.ReadLine());
                }

                int counterForFirst = firstMyArray.Length / 2;
                int counterForSecond = 0;

                while (counterForSecond < firstMyArray.Length / 2)
                {
                    int counter = firstMyArray[counterForSecond];
                    firstMyArray[counterForSecond] = firstMyArray[counterForFirst];
                    firstMyArray[counterForFirst] = counter;

                    counterForSecond++;
                    counterForFirst++;
                }

                for (int i = 1; i < firstMyArray.Length; i++)
                {
                    Console.Write(firstMyArray[i]);
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
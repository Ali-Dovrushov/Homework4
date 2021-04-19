using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
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

                int[] secondMyArray = new int [arrayElements];

                for (int i = 0; i < firstMyArray.Length; i++)
                {
                    secondMyArray[i] = firstMyArray[arrayElements-1];
                    arrayElements--;
                    
                }

                foreach (int numElements in secondMyArray)
                {
                    Console.Write($"{numElements} ");
                }

                

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

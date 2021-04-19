//using System;

//namespace Question8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] nums1 = new int[ArrayElements, ArrayElements1];

//            int[] nums2 = new int[3];

//            int[] nums3 = new int[3];

//            for (int i = 0; i < nums1.Length-2; i++)
//            {
//                nums1[i,i] = nums2[2];
//                Console.WriteLine(nums2);
//            }
//        }
//    }
//}
using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question №1");

            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                Console.Write("Enter array elements: ");

                int arrayElements = int.Parse(Console.ReadLine());
                int[] firstMyArray = new int[arrayElements];
                int[] secondMyArray = new int [arrayElements];

                for (int i = 0; i < firstMyArray.Length; i++)
                {
                    Console.Write($"Enter {i} index, array number: ");
                    firstMyArray[i] = int.Parse(Console.ReadLine());
                }

                int a = firstMyArray.Length / 2;

                for (int i = 0; i <= a; i++)
                {
                    if (a % 2 == 0)
                    {
                        secondMyArray[i] = firstMyArray[firstMyArray.Length / 2 + i];
                        a--;
                        Console.WriteLine(secondMyArray[i]);
                    }
                    else if (a % 2 != 0)
                    {
                        secondMyArray[i] = firstMyArray[firstMyArray.Length / 2 + i];
                        a++;
                        Console.WriteLine(secondMyArray[i]);
                    }
                }

                for (int i = a; i < firstMyArray.Length / 2; i++)
                {
                    secondMyArray[i] = firstMyArray[i];
                    a++;
                    Console.WriteLine(secondMyArray[i]);
                }

                //for (int i = arrayElements / 2 ; i < arrayElements; i++)
                //{
                //    secondMyArray[i] = firstMyArray[i];
                //    firstMyArray[i] = firstMyArray[arrayElements / 2];
                //    firstMyArray[arrayElements / 2] = secondMyArray[i];
                //    //Console.WriteLine(secondMyArray[i]);
                //    arrayElements--;
                //    Console.WriteLine(firstMyArray[i]);
                //}

                //int[] nums5 = new int[6];

                //int count1 = 0;
                //int count2 = nums5.Length / 2;

                //for (int i = 0; i < nums5.Length; i++)
                //{
                //    Console.Write("{0} number = ", i + 1);

                //    nums5[i] = Int32.Parse(Console.ReadLine());
                //}
                //while (count1 < nums5.Length / 2)
                //{

                //    int temp = nums5[count1];
                //    nums5[count1] = nums5[count2];
                //    nums5[count2] = temp;

                //    count1++;
                //    count2++;
                //}

                //for (int i = 0; i < nums5.Length; i++)
                //{
                //    Console.Write(nums5[i]);
                //}
                //Console.WriteLine("\nPress any button...");
                //Console.ReadKey();

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
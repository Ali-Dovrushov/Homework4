using System;

namespace Question11
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
                int firstPersonTryAge;
                int secondPersonTryAge;
                string firstNameForCompare;
                string secondNameForCompare;
                bool checkerFirstPerson = true;
                bool checkerSecondPerson = true;

                do
                {
                    Console.Write("Enter first person name: ");
                    string firstPersonName = Convert.ToString(Console.ReadLine());

                    for (int i = 0; i < firstPersonName.Length; i++)
                    {
                        char element = firstPersonName[i];

                        if (!Char.IsLetter(element))
                        {
                            checkerFirstPerson = false;
                            Console.WriteLine("Incorrect name type, please enter correct name\n");
                            break;
                        }
                        else
                        {
                            checkerFirstPerson = true;
                        }
                    }
                    firstNameForCompare = firstPersonName;
                }
                while (checkerFirstPerson == false);

                do
                {
                    Console.Write("Enter first person age: ");
                    string firstPersonAge = Convert.ToString(Console.ReadLine());
                    bool firstAge = int.TryParse(firstPersonAge, out firstPersonTryAge);

                    for (int i = 0; i < firstPersonAge.Length; i++)
                    {
                        char elementForFirstAge = firstPersonAge[i];

                        if (firstPersonTryAge < 0)
                        {
                            checkerFirstPerson = false;
                            Console.WriteLine("Age cannot be negativ number");
                            break;
                        }
                        else if (Char.IsLetter(elementForFirstAge))
                        {
                            checkerFirstPerson = false;
                            Console.WriteLine("Incorrect age type, please enter correct age\n");
                            break;
                        }
                        else
                        {
                            checkerFirstPerson = true;
                        }
                    }
                }
                while (checkerFirstPerson == false);

                do
                {
                    Console.Write("Enter second person name: ");
                    string secondPersonName = Convert.ToString(Console.ReadLine());

                    for (int i = 0; i < secondPersonName.Length; i++)
                    {
                        char elementForSecondName = secondPersonName[i];

                        if (!Char.IsLetter(elementForSecondName))
                        {
                            checkerSecondPerson = false;
                            Console.WriteLine("Incorrect name type, please enter correct name\n");
                            break;
                        }
                        else
                        {
                            checkerSecondPerson = true;
                        }
                    }
                    secondNameForCompare = secondPersonName;
                }
                while (checkerSecondPerson == false);

                do
                {
                    Console.Write("Enter second person age: ");
                    string secondPersonAge = Convert.ToString(Console.ReadLine());
                    bool secondAge = int.TryParse(secondPersonAge, out secondPersonTryAge);

                    for (int i = 0; i < secondPersonAge.Length; i++)
                    {
                        char elementForSecondAge = secondPersonAge[i];

                        if (secondPersonTryAge < 0)
                        {
                            checkerSecondPerson = false;
                            Console.WriteLine("Age cannot be negativ number");
                            break;
                        }
                        else if (Char.IsLetter(elementForSecondAge))
                        {
                            checkerSecondPerson = false;
                            Console.WriteLine("Incorrect age type, please enter correct age\n");
                            break;
                        }
                        else
                        {
                            checkerSecondPerson = true;
                        }
                    }
                }
                while (checkerSecondPerson == false);

                bool ageComparing = true;
                string sameAge = "same";

                do
                {
                    Console.Write($"Who is older {firstNameForCompare}, {secondNameForCompare} or {sameAge}(if same, please type = same) ? Please enter name: ");
                    string checkerForCompare = Convert.ToString(Console.ReadLine());

                    if (checkerForCompare == firstNameForCompare)
                    {
                        if (firstPersonTryAge > secondPersonTryAge)
                        {
                            Console.WriteLine($"{firstNameForCompare} older than {secondNameForCompare} on {firstPersonTryAge - secondPersonTryAge} years");
                        }
                        else if (firstPersonTryAge < secondPersonTryAge)
                        {
                            Console.WriteLine($"{firstNameForCompare} not older than {secondNameForCompare}");
                        }
                        else if (firstPersonTryAge == secondPersonTryAge)
                        {
                            Console.WriteLine("No, they are the same age");
                        }
                    }

                    else if (checkerForCompare == secondNameForCompare)
                    {
                        if (secondPersonTryAge > firstPersonTryAge)
                        {
                            Console.WriteLine($"{secondNameForCompare} older than {firstNameForCompare} on {secondPersonTryAge - firstPersonTryAge} years");
                        }
                        else if (secondPersonTryAge < firstPersonTryAge)
                        {
                            Console.WriteLine($"{secondNameForCompare} not older than {firstNameForCompare}");
                        }
                        else if (firstPersonTryAge == secondPersonTryAge)
                        {
                            Console.WriteLine("No, they are the same age");
                        }
                    }

                    else if (checkerForCompare == sameAge)
                    {
                        if (firstPersonTryAge == secondPersonTryAge)
                        {
                            Console.WriteLine("Yes, they are the same age ");
                        }
                        else if (firstPersonTryAge > secondPersonTryAge)
                        {
                            Console.WriteLine("No, they are not a same age ");
                        }
                        else if (firstPersonTryAge < secondPersonTryAge)
                        {
                            Console.WriteLine("No, they are not a same age ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You enter incorrect name, please enter valid name.");
                        ageComparing = false;
                    }
                }
                while (ageComparing == false);



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

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace PPC
{
    class HelloCSharp
    {
        static void Main()
        {

            #region
            //-----------------------------------------------------------------------
            //Write a program that prints the following numbers on the console 1,
            //101, 1001, each on a new line.

            //int a = 1, b = 101, c = 1001;
            //Console.WriteLine("{0}\n{1}\n{2}", a, b, c);

            //int number = 12345;

            //double result = Math.Sqrt(number);

            //Console.WriteLine(result);

            //Write a program that prints the first 100 members of the sequence 2, -
            //    3, 4, -5, 6, -7, 8.
            //--------------------------------------------------------------------------
            //Write a program that prints the first 100 members of the sequence 2, -
            //3, 4, -5, 6, -7, 8.

            //int number = 100;

            //for (int i = 2; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine(-i);
            //    }

            //}
            //--------------------------------------------------------------------------
            //Write a program that reads your age from the console and prints your
            //age after 10 years.

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"You will be {age + 10} years old after 10 years.");

            //--------------------------------------------------------------------------

            //string greeting1 = "Hello";
            //string greeting2 = "World";

            //object joinedGreeting = greeting1 + " " +  greeting2;
            //Console.WriteLine(joinedGreeting);

            //--------------------------------------------------------------------------

            //string greeting1 = "hello";
            //string greeting2 = "world";
            //object joinedgreeting = greeting1 + " " + greeting2;
            //string result = (string)joinedgreeting;

            //Console.WriteLine(result);

            //--------------------------------------------------------------------------

            ////string first = "The"use" of quotations causes difficulties.";
            //string second = "The\"use\" of quotations causes difficulties.";

            ////Console.WriteLine(first);
            //Console.WriteLine(second);

            //Console.WriteLine("  0 0  0 0 ");
            //Console.WriteLine(" 0   00    0 ");
            //Console.WriteLine("0           0");
            //Console.WriteLine("  0       0 ");
            //Console.WriteLine("    0    0 ");
            //Console.WriteLine("      00");

            //--------------------------------------------------------------------------

            //int a = 5;
            //int b = 10;

            //a = a + b; //15
            //b = a - b; //5
            //a = a - b; //10

            //--------------------------------------------------------------------------

            //Console.WriteLine("Please enter a number between 2 and 100: ");
            //int number = int.Parse(Console.ReadLine());

            //bool results = (number % 2 == 0) ? true: false;

            //if (results)
            //    Console.WriteLine("The number is even.");
            //else
            //    Console.WriteLine("The number is odd.");

            //--------------------------------------------------------------------------

            //    Console.WriteLine("Please enter a number between 1 and 100:");
            //    int number = int.Parse(Console.ReadLine());



            //    bool result = (number % 7 == 0 && number % 5 == 0) ? true : false;

            //    if (result)
            //        Console.WriteLine("Both numbers are divisible.");
            //    else
            //        Console.WriteLine("Both numbers are not divisible.");

            //--------------------------------------------------------------------------


            //    int [] statues = new int[] {12, 2, 3, 5, 11 };

            //    int min, temp;
            //for (int outer = 0; outer <= statues.Length; outer++)
            //{
            //    min = outer;
            //    for (int inner = outer + 1; inner <= statues.Length; inner++)
            //        if (statues[inner] < statues[min])
            //        { 
            //            min = inner;
            //            temp = statues[outer];
            //            statues[outer] = statues[min];
            //            statues[min] = temp;
            //        }

            //                Console.WriteLine($"The min is {min}. The temp is .");
            //}

            //--------------------------------------------------------------------------

            //Console.WriteLine("Please enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //int isThirdDigit = (number / 100) % 10;

            //if (isThirdDigit == 7)
            //{
            //    Console.WriteLine("The third number is equal to 7.");
            //}
            //else
            //{
            //    Console.WriteLine("The third number is not equal to 7.");
            //}

            //--------------------------------------------------------------------------

            //Area = (b*2/2)*h

            //Console.WriteLine("Please enter \"a\" for the first base 1: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter \"b\" for the second base 1: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter \"h\" for the height: ");
            //int h = Convert.ToInt32(Console.ReadLine());

            //int area = ((a + b) / 2) * 2;

            //Console.WriteLine($"The area of a trapazoid is {area}");

            //--------------------------------------------------------------------------
            //int counter = 0;

            //while (counter <= 9)
            //{
            //    Console.WriteLine("Number: " + counter);
            //    counter++;
            //}

            //--------------------------------------------------------------------------

            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;
            //int sum = 1;
            //Console.Write("The sum 1");
            //while (num < n)
            //{
            //    num++;
            //    sum += num;
            //    Console.Write(" + " + num);
            //}
            //Console.WriteLine(" = " + sum);



            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(arr[0]);

            //string greeting = "Hello!";
            //Console.WriteLine(greeting[3]);

            //--------------------------------------------------------------------------

            //int? a = 5;
            //Console.WriteLine(a ?? -1);

            //string name = null;
            //Console.WriteLine(name ?? "(no name)");

            //--------------------------------------------------------------------------

            //Console.WriteLine("{0:C2}", 123.456);
            ////Output: 123,46 лв.
            //Console.WriteLine("{0:D6}", -1234);
            ////Output: -001234
            //Console.WriteLine("{0:E2}", 123);
            ////Output: 1,23E+002
            //Console.WriteLine("{0:F2}", -123.456);

            //--------------------------------------------------------------------------

            //DateTime d = new DateTime(2019, 04, 24, 14, 20, 22);
            //Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",d);
            //Console.WriteLine("{0: d.MM.yy}",d);

            //--------------------------------------------------------------------------

            //    Console.WriteLine("Please enter two numbers: ");

            //    Console.WriteLine("Enter the first number: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter the second number: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());

            //    for (int i = number1; i <= number2; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }

            //--------------------------------------------------------------------------

            //int[] statues = {6 , 3 };

            //int counter = 0;
            //int min;


            //for (int i = 0; i < statues.Length; i++)
            //{
            //    for (int j = i + 1; j < statues.Length; j++)
            //    {
            //        if (statues[i] > statues[j])
            //        {

            //            min = statues[j];
            //            statues[j] = statues[i];
            //            statues[i] = min;
            //            counter++;

            //        }
            //        if (statues[i]< statues )
            //        {

            //        }

            //        if (statues[i] == 0)
            //        {
            //            statues[i]++;

            //            while (statues[i] < statues[j])
            //            {
            //                statues[i]++;
            //                counter++;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"The counts = {counter}");

            //--------------------------------------------------------------------------

            //Console.WriteLine("Please enter a number greater than 2: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < number; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //--------------------------------------------------------------------------

            //Console.WriteLine("Please enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isDivisible = (number % (3 * 7) == 0) ? true : false;
            //if (isDivisible)
            //{
            //    Console.WriteLine($"The number {number} is divisible by 3 or 7.");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {number} is not divisible by 3 or 7.");
            //}

            //--------------------------------------------------------------------------

            //        int smallest = 0;
            //        int largest = 0;
            //        int input;

            //        Console.WriteLine("Please enter the number of inputs:");
            //        int num = int.Parse(Console.ReadLine());

            //        for (int i = 0; i < num; i++)
            //        {
            //            Console.WriteLine($"Enter number: ");
            //            input = Int32.Parse(Console.ReadLine());

            //            if (i == 0)
            //            {
            //                smallest = largest = input;  
            //            }
            //            else
            //            {
            //                if (smallest > input)
            //                {
            //                    smallest = input;
            //                }
            //                if (smallest < input)
            //                {
            //                    largest = input;

            //                }
            //            }
            //        }

            //        Console.WriteLine($"The smallest number is {smallest} and the largest number is {largest}");

            //--------------------------------------------------------------------------

            //string[] spade;
            //string [] hearts;
            //string [] diamonds;
            //string [] clubs;


            //for (int i = 0; i < 4; i++)
            //{
            //    if (i != 0) Console.WriteLine();

            //    for (int j = 0; j < 13; j++)
            //    {
            //        switch (i)
            //        {
            //            case 0: Console.Write("Hearts "); break;
            //            case 1: Console.Write("Diamonds "); break;
            //            case 2: Console.Write("Spades "); break;
            //            case 3: Console.Write("Clubs "); break;
            //        }
            //        switch (j)
            //        {
            //            case 0: Console.WriteLine("2"); break;
            //            case 1: Console.WriteLine("3"); break;
            //            case 2: Console.WriteLine("4"); break;
            //            case 3: Console.WriteLine("5"); break;
            //            case 4: Console.WriteLine("6"); break;
            //            case 5: Console.WriteLine("7"); break;
            //            case 6: Console.WriteLine("8"); break;
            //            case 7: Console.WriteLine("9"); break;
            //            case 8: Console.WriteLine("10"); break;
            //            case 9: Console.WriteLine("J"); break;
            //            case 10: Console.WriteLine("Q"); break;
            //            case 11: Console.WriteLine("K"); break;
            //            case 12: Console.WriteLine("A"); break;
            //        }
            //    }
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------
            //int first = 0;
            //int second = 1;
            //int third = 0;
            //Console.WriteLine("Please enter a number:");
            //int length = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("0\n1");

            //for (int i = 2; i < length; i++)
            //{
            //    third = first + second;
            //    Console.WriteLine("{0}", third);
            //    first = second;
            //    second = third;
            //}

            //--------------------------------------------------------------------------

            //int[] arr = new int[20];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i * 5;
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Random ran = new Random();
            //var r = new Random();
            //string[] color = { "Red", "Black" };
            //string guess;
            //int attempts = 0;
            //int bet;
            //int money = 500;
            //while (money != 0)
            //{
            //    Console.WriteLine("Roulette Roller by Cornell\n");
            //    Console.WriteLine("Money:$" + money + "                  Attempts: " + attempts);
            //    Console.WriteLine("Type in any off the following letters below:");
            //    Console.WriteLine("a.Even    b.Odd    c.1 to 18    d.19 to 36");
            //    Console.WriteLine("e.Red     f.Black  g.1st 12     h.2nd 12");
            //    Console.WriteLine("i.3rd 12");
            //    guess = (Console.ReadLine());
            //    //guess verifier
            //    guess.ToLower();
            //    bool check = guess == "a" || guess == "b" || guess == "c" || guess == "d" || guess == "e" || guess == "f" || guess == "g" || guess == "h" || guess == "i";
            //    if (check == false)
            //    {
            //        Console.WriteLine("You did not enter the correct input value(even/odd)");
            //        Console.ReadKey();
            //        Console.Clear();
            //        continue;
            //    }
            //    else
            //    {
            //    bet:
            //        Console.WriteLine("Enter an amount to bet");
            //        bet = Convert.ToInt32(Console.ReadLine());
            //        //bet verifier
            //        if (bet > money)
            //        {
            //            Console.WriteLine("You dont have enough money!");
            //            Console.WriteLine("Press enter to try again.");
            //            Console.ReadKey();
            //            goto bet;
            //        }
            //        else
            //        {
            //            money -= bet;
            //            int roll = ran.Next(0, 37);
            //            string ranColor = color[r.Next(color.Length)];
            //            bool even = roll % 2 == 0;
            //            if ((((guess == "a") && (even == true))) || (((guess == "b") && (even == false))) || ((guess == "e") && (ranColor == "Red") || (guess == "f") && (ranColor == "Black")))
            //            {
            //                Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
            //                Console.WriteLine("You won! +$" + bet * 2 + "!");
            //                Console.WriteLine("<Press enter to continue>");
            //                money += bet * 2;
            //                attempts += 1;
            //                Console.ReadKey();
            //            }
            //            else if ((guess == "c") && ((roll > 0) && (roll < 19)))
            //            {
            //                Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
            //                Console.WriteLine("You won! +$" + bet * 2 + "!");
            //                Console.WriteLine("<Press enter to continue>");
            //                money += bet * 2;
            //                attempts += 1;
            //                Console.ReadKey();
            //            }
            //            else if ((guess == "d") && ((roll > 18) && (roll < 37)))
            //            {
            //                Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
            //                Console.WriteLine("You won! +$" + bet * 2 + "!");
            //                Console.WriteLine("<Press enter to continue>");
            //                money += bet * 2;
            //                attempts += 1;
            //                Console.ReadKey();
            //            }
            //            else if ((guess == "g") && (roll > 0 && roll < 13) || (guess == "h") && (roll > 12 && roll < 25) || (guess == "i") && (roll > 24 && roll < 37))
            //            {
            //                Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
            //                Console.WriteLine("You won! +$" + bet * 2 + "!");
            //                Console.WriteLine("<Press enter to continue>");
            //                money += bet * 3;
            //                attempts += 1;
            //                Console.ReadKey();
            //            }
            //            else
            //            {
            //                Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
            //                Console.WriteLine("You lost! -$" + bet + "!");
            //                Console.WriteLine("<Press enter to continue>");
            //                attempts += 1;
            //                Console.ReadKey();
            //                if (money == 0)
            //                {
            //                    Console.WriteLine("You are out of money.");
            //                    Console.WriteLine("<Press enter to continue>");
            //                    Console.ReadKey();
            //                }
            //            }
            //        }
            //    }
            //    Console.Clear();

            //}


            //Car car1 = new Car();

            //car1.Color = "Black";
            //car1.Engine = "V8";
            //car1.Model = "Accord";
            //car1.Make = "Honda";

            //Console.WriteLine(car1);


            ////List<Car> car = new List<Car>();
            ///

            //--------------------------------------------------------------------------

            //var list = new List<KeyValuePair<string, int>>();

            //list.Add(new KeyValuePair<string, int>("Cat", 1));
            //list.Add(new KeyValuePair<string, int>("Dog", 2));
            //list.Add(new KeyValuePair<string, int>("Rat", 3));
            //list.Add(new KeyValuePair<string, int>("Horse", 4));
            //list.Add(new KeyValuePair<string, int>("Mice", 5));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Value);

            //}

            //--------------------------------------------------------------------------

            //Dictionary<string, int> birds = new Dictionary<string, int>()
            //{
            //    {"Cardinal", 10 },
            //    {"Robin", 5 }
            //};

            //foreach (var bird in birds)
            //{
            //    Console.WriteLine($"Pair here: {bird.Key}, {bird.Value}");
            //}

            //var info = new List<KeyValuePair<int, int>>()
            //{
            //    new KeyValuePair<int, int>(1,6),
            //    new KeyValuePair<int, int>(2,3),
            //    new KeyValuePair<int, int>(3,4)
            //};

            //info.Sort((a, b) => (b.Value.CompareTo(a.Value)));

            //foreach (var item in info)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------

            //Person person1 = new Person();
            //Console.WriteLine(person1.Name);

            //Person person2 = new Person("Cornell Reddick");
            //Console.WriteLine(person2.Name);

            //Console.WriteLine(person2);
            #endregion


            //int[] array = { 1, 3, 5, 7, };
            //Console.WriteLine(array.Average());

            //Console.WriteLine(MultiplyByTwo(8));


            //int [] array = { 1,2,3,4,5,6,7,8 };

            //var elements = from element in array
            //               orderby element descending
            //               where element > 2
            //               select element;

            //foreach (var element in elements)
            //{
            //    Console.WriteLine(element);
            //    Console.WriteLine(" ");
            //}

            //string[] siblings = { "Tasha", "Maurice", "Samuel", "Armando", "Ellona" };

            //var members = from member in siblings
            //              orderby member ascending
            //              select member;

            //foreach (var member in members)
            //{
            //    Console.WriteLine(member + " " + "Reddick");
            //    Console.WriteLine(" ");
            //}

            //--------------------------------------------------------------------------

            //int[] values = { 10, 0, 1, 1, 20, 300, 400, 4 };


            ////Using Linq
            //var start1 = Stopwatch.StartNew();
            //for (int i = 0; i < _max; i++)
            //{
            //    int count = CountLinq(values);
            //}

            //start1.Stop();

            ////Using For
            //var start2 = Stopwatch.StartNew();
            //for (int i = 0; i < _max; i++)
            //{
            //    int count = CountFor(values);
            //}

            //start2.Stop();

            //Console.WriteLine("Linq");
            //Console.WriteLine(((double)(start1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            //Console.WriteLine("For");
            //Console.WriteLine(((double)(start2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));

            //--------------------------------------------------------------------------

            //const int _max = 1000000;

            //public static int MultiplyByTwo(int value)
            //{
            //    return value * 2;
            //}


            // the difference between using count with Linq and the For iteration.
            //static int CountLinq(int [] values)
            //{
            //    // We will count values that are greater then or equal to 10 using Linq
            //    return (from x in values
            //            where x >= 10
            //            select x).Count();
            //}

            //static int CountFor(int[] values)
            //{
            //    // Count values greater than or equal to 10 with loop.
            //    int count = 0;
            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        if (values[i] >= 10)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}


            //--------------------------------------------------------------------------

            //Person person1 = new Person();
            //person1.Name = "Cornell Reddick";
            //person1.Age = 40;
            //person1.Running();

            //Person person2 = new Person("Maurice Reddick", 47);
            //person2.Dunking();

            //Console.WriteLine($"{person1.Name} is {person1.Age}\n{person2.Name} is {person2.Age}");

            //--------------------------------------------------------------------------

            //string str = "I'm going to select the number 7 from this string.";
            //str.Count();
            //Console.WriteLine(str.Count());

            //string stri = "aabaa";

            //if (stri[0] == stri[4])
            //{
            //    Console.WriteLine("They are equal.");
            //}


            //Animal animal1 = new Animal("Rex", "Red", "Dog");
            //animal1.Speak();


            //Animal animal2 = new Animal("Fuzzy", "Black", "Cat");
            //animal2.Speak();

            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
        }


        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }


    }

}

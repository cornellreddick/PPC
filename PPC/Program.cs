using System;
using System.IO;
using System.Threading.Tasks;

namespace PPC
{
    class HelloCSharp
    {
        static void Main()
        {
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

        //}

    }
}

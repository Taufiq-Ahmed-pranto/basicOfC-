using System;

namespace fundamentalCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //data types in c#

            //1 byte = 8 bits


            int myInt = 10;//4 bytes
            double myDouble = 10.25;//8 bytes
            bool myBool = true;//1 bit
            long myLong = 100;//8 bytes
            float myFloat = 2.5f;// 4 bytes
            char myChar = 'A';//2 bytes
            string myString = "Dhaka";// 2 bytes per character

            //type casting in c#:

            // 1. implicit type casting or automatic type casting: smaller to larger
            // char -> int -> long -> float -> double


            // 2. explicit type casting or manualy type casting: larger to smaller
            // double -> float -> long -> int -> char

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            /*
            // taking input from user:
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);

            // taking numetical input from user
            Console.WriteLine("Enter an age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age is " + age);
            */
            //arithmatic operator in c#:

            int a = 10;
            int b = 5;
            Console.WriteLine("arithmatic operator");
            Console.WriteLine(a + b);//addition
            Console.WriteLine(a - b);//subtraction
            Console.WriteLine(a * b);//multipication
            Console.WriteLine(a / b);//division
            Console.WriteLine(a % b);//modulus
            Console.WriteLine(++a);//increment
            Console.WriteLine(--b);//decrement


            // assignment operator:

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("assignment operator");
            Console.WriteLine(num1 += 10);
            Console.WriteLine(num1 -= 10);
            Console.WriteLine(num1 *= 10);
            Console.WriteLine(num1 /= 10);
            Console.WriteLine(num1 %= 10);

            // bit wise operator
            Console.WriteLine("bitwise operator");
            Console.WriteLine( 1&3);// and
            Console.WriteLine(3|10);// or
            Console.WriteLine(20^10);//xor
            Console.WriteLine(10>>1);//right shift
            Console.WriteLine(10<<1);//left shift
            Console.WriteLine(~10);// not

            //comparision operator
            Console.WriteLine("comparision operator");
            Console.WriteLine(10 < 2);
            Console.WriteLine(10 > 2);
            Console.WriteLine(10 <= 2);
            Console.WriteLine(10 >= 2);
            Console.WriteLine(10 == 2);
            Console.WriteLine(10 != 2);

            Console.WriteLine("logical operator");
            Console.WriteLine(10 < 2 && 10==10);
            Console.WriteLine(10 < 2 || 10==10);
            Console.WriteLine(!(10 < 2 || 10==10));

            //Math class:
            Console.WriteLine("math class");
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(4.8));
            Console.WriteLine(Math.Pow(10, 3));
            Console.WriteLine(Math.MaxMagnitude(10.76, 20.45));
            Console.WriteLine(Math.Abs(-8));

            //string class
            Console.WriteLine("String class");
            string hello = "Hello World";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());

            //concate a string
            string firstName = "taufiq";
            string lastName = "Ahmed";

            Console.WriteLine(firstName + " " + lastName);

            //strig interpolation

            string name = $"my full name is {firstName} {lastName}";

            Console.WriteLine(name);

            // access a string:

            string name1 = "Taufiq Ahmed";

            Console.WriteLine(name1[0]);

            Console.WriteLine(name1.IndexOf('q'));

            Console.WriteLine(name1.Substring(name1.IndexOf('A')));


            // special character:

            string quote = "We are the so called \"Vikings\" from the north";

            Console.WriteLine(quote);

            Console.WriteLine("if else statement:");

            int time = 9;

            if (time > 10)
            {
                Console.WriteLine("you are late");
            }
            else if(time < 10)
            {
                Console.WriteLine("you are early");
            }
            else
            {
                Console.WriteLine("you are on time");
            }

            //short hand if-else:
            time = 14;
            string result = (time < 18) ? "good day" : "good evening";
            Console.WriteLine(result);

            Console.WriteLine("switch case option:");

            switch (time)
            {
                case 13:
                    Console.WriteLine("it's 1 pm");
                    break;
                case 14:
                    Console.WriteLine("it's 2 pm");
                    break;
                case 15:
                    Console.WriteLine("it's 3 pm");
                    break;
                default:
                    Console.WriteLine("No time matching");
                    break;
            }

            Console.WriteLine("loops in c#:");

            // white loop in c#:

            int i = 1;
            Console.WriteLine(" while loop in c#:");
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("do while loop in c#:");
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);

            Console.WriteLine("for loop in c#:");

            for(int ab=1; ab <= 5; ab++)
            {
                if (ab == 2)
                {
                    continue;
                }
                if (ab == 5)
                {
                    break;
                }
                Console.WriteLine(ab);
            }

            string[] cars = { "BMW", "Audi", "Toyota" };

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }


            //arrays in c#:

            Console.WriteLine("Arrays in c#:");

            /*int[] numbers = new int[3];

            for(int index=0; index<numbers.Length; index++)
            {
                numbers[index] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }*/

            Console.WriteLine("some useful method in array:");
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // sort array

            Array.Sort(myNumbers);

            foreach(int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            // 2d array:

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            //method in c#:
            Console.WriteLine("Method in c#:");


            MyMethod();

            //method with parameter:

            NamePrint("Taufiq");
            //default parameter:
            NamePrint();

            int addNum = AddTwoNumber(5, 7);

            Console.WriteLine(addNum);

            //order of arhuments:

            ChildrenName(name1: "resve", name2: "ronvee", name3: "alvee");


            Console.WriteLine("method overloading: method name same but parameter are different");

            Console.WriteLine(Add(1, 2, 2));
            Console.WriteLine(Add(1, 2));





        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void MyMethod()
        {
            Console.WriteLine("My method is executed");
        }

        static void NamePrint(string name="X")
        {
            Console.WriteLine("He Mr. " + name);
        }

        static int AddTwoNumber(int x, int y)
        {
            return x + y;
        }

        static void ChildrenName(string name1, string name2, string name3)
        {
            Console.WriteLine("younger is: " + name3);
        }
    }
}
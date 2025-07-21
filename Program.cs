﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
class Program
{

  public static void Main(String[] args)
  {
    /* Console.WriteLine("Hello C#");
     bool a = true; 
   Console.WriteLine(a);*/



    /*Console.WriteLine("VALUE TYPE:");
      Console.WriteLine("__________________________");
      Console.WriteLine("Integers:");
      byte a = 12;
      Console.WriteLine("byte\tA  = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);
      sbyte b = 12;
      Console.WriteLine("sbyte\tB  = {0}\t{1}\t{2}\t{3}", b, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
      short c = 12;
      Console.WriteLine("short\tC  = {0}\t{1}\t{2}\t{3}", c, typeof(short), short.MaxValue, short.MinValue);
      ushort d = 12;
      Console.WriteLine("ushort\tD  = {0}\t{1}\t{2}\t{3}", d, typeof(ushort), ushort.MaxValue, ushort.MinValue);
      int e = 12;
      Console.WriteLine("int\tE = {0}\t{1}\t{2}\t{3}", e, typeof(int), int.MaxValue, int.MinValue);
      int f = 12;
      Console.WriteLine("uint\tF = {0}\t{1}\t{2}\t{3}", f, typeof(uint), uint.MaxValue, uint.MinValue);
      int g = 12;
      Console.WriteLine("long\tG = {0}\t{1}\t{2}\t{3}", g, typeof(long), long.MaxValue, long.MinValue);
      int h = 12;
      Console.WriteLine("ulong\tH = {0}\t{1}\t{2}\t{3}", h, typeof(ulong), ulong.MaxValue, ulong.MinValue);



      Console.WriteLine("\nFloating Point:");
      float i = 123.34f;
        Console.WriteLine ("float\tI = {0}\t{1}\t{2}\t{3}", i, typeof(float), float.MaxValue, float.MinValue);
      double j = 123.34;
      Console.WriteLine("double\tJ = {0}\t{1}\t{2}\t{3}", j, typeof(double), double.MaxValue, double.MinValue);
      decimal k= 123.34m;
     Console.WriteLine ("decimal\tK = {0}\t{1}\t{2}\t{3}", k, typeof(decimal), decimal.MaxValue, decimal.MinValue);


      Console.WriteLine("\nText:");
      char l = 'f';
      Console.WriteLine("char\tL = {0}\t{1}\t{2}\t{3}", l, typeof(char));


      Console.WriteLine("\nBoolean:");
    bool m = true;
      Console.WriteLine("bool\tM = {0}\t{1}", m, typeof(bool));*/


    //Arithmetic Operator
    //{addition}
    /* int sum = 5 + 3;
     Console.WriteLine($"5+3 = {sum}");

     //{subtraction}
     int difference = 10 - 4;
     Console.WriteLine($"10-4 = {difference}");

     //{multiplication}
     int product = 6 * 7;
     Console.WriteLine($"6*7 = {product}");

     //{division}
     int quotient = 15 / 3;
     double preciseQuotient = 15.0 / 4.0;
     Console.WriteLine($"15.0/4.0 = {preciseQuotient}");
     Console.WriteLine($"15.0/3.0 = {quotient}");

     //{modulus}
     int remainder = 17 % 5;
     Console.WriteLine($"17%5 ={remainder}");

     //{increment}
     int count = 5;
     count++;
     Console.WriteLine($"After increment:{count}");
     int preIncrement = ++count;
     Console.WriteLine($"After pre-Increment: count={count}, preIncrement{preIncrement}");

     //{decrement}
     int value = 8;
     value++;
     Console.WriteLine($"After decrement:{value}");
     int preDecrement = ++value;
     Console.WriteLine($"After pre-Decrement: value={value}, preDecrement{preDecrement}");

     //{combined all operators}
     int x = 10;
     x += 5;
     x -= 3;
     x *= 2;
     x /= 4;
     x %= 5;
     Console.WriteLine($"Final x value : {x}");

     //{Assignment operator}

     //simple Assigment
     int a = 10;
     string name = "john";
     Console.WriteLine($" a = {a},name = {name}");

     //addtion assignment
     int b = 5;
     b += 3;
     Console.WriteLine($"b = {b}");

     //subtraction assignmenmt
     int c = 10;
     c -= 4;
     Console.WriteLine($"c = {c}");

     //multiply assignment
     int d = 3;
     d *= 5;
     Console.WriteLine($"d = {d}");

     //division operator
     int e = 20;
     e /= 4;
     Console.WriteLine($"e = {e}");

     //modulus operator
     int f = 17;
     f %= 5;
     Console.WriteLine($"f = {f}");

     //bitwise AND and asignment
     int g = 6;
     g &= 3;
     Console.WriteLine($"g = {g}");

     //OR assignment
     int h = 6;
     h |= 3;
     Console.WriteLine($"h = {h}");

     //NOT assignment
     int i = 6;
     i = ~3;
     Console.WriteLine($"i = {i}");

     //left shift assignment
     int j = 4;
     j <<= 1;
     Console.WriteLine($"j = {j}");

     //Right shift assignment
     int k = 8;
     k >>= 1;
     Console.WriteLine($"k = {k}");

     //{Comparision operator}

     int l = 10;
     int m = 5;

     Console.WriteLine($"l = {l}, m = {m}");
     Console.WriteLine();

     //equal to
     int n = 11;
     int o = 4;
     Console.WriteLine($"n == o: {n == o}");
     Console.WriteLine($"11 == 11: {11 == 11}");

     //not equal to
     Console.WriteLine($"n != o: {n != o}");
     Console.WriteLine($"11 != 11: {11 != 11}");

     //greater than
     Console.WriteLine($"n > o: {n > o}");
     Console.WriteLine($"11 > 11: {11 > 11}");

     //Less than
     Console.WriteLine($"n < o: {n < o}");
     Console.WriteLine($"11 < 11: {11 < 11}");

     //greater than or equal to
     Console.WriteLine($"n >= o: {n >= o}");
     Console.WriteLine($"11 >= 11: {11 >= 11}");
     Console.WriteLine($"4 >= 11: {4 >= 11}");

     //less than or equal to
     Console.WriteLine($"n <= o: {n <= o}");
     Console.WriteLine($"11 <= 11: {11 <= 11}");
     Console.WriteLine($"4 <= 11: {4 <= 11}");

     //string comparision
     string s1 = "hello";
     string s2 = "world";
     Console.WriteLine($"\nString comparison:");
     Console.WriteLine($"\"hello\" == \"hello\": {"hello" == "hello"}");
     Console.WriteLine($"s1 == s2: {s1 == s2}");

     //{logical operators}

     //logical AND
     bool p = true;
     bool q = false;
     Console.WriteLine(p && q);

     //logical OR
     Console.WriteLine(p || q);

     //logical NOT
     Console.WriteLine(!p);

     //BitWise Operators

     int r = 5;
     int s = 3;
     //bitwise AND
     int result = r & s;
     Console.WriteLine(result);

     //bitwise OR
     int t = 5;
     int u = 3;
     Console.WriteLine($"t | s: {t | u}");

     //bitwise XOR
     Console.WriteLine($"t ^ u: {t ^ u}");

     //bitwise NOT
     Console.WriteLine($"~t: {~t}");

     //leftshift
     Console.WriteLine($"t << 1: {t << 1}");

     //rightshift
     Console.WriteLine($"t >> 1 : {t >> 1}");

     //condtional operators
     int age = 20;
     string status = age >= 18 ? "Adult" : "Minor";
     Console.WriteLine(status);

     //null
     int? length = name?.Length;
     Console.WriteLine(length);

     //sizeof operator
     int size = sizeof(int);
     Console.WriteLine(size);

     //typeof operator
     Type type = typeof(string);
     Console.WriteLine(type);

     //name of operator
     string methodName = nameof(Console.WriteLine);
     Console.WriteLine(methodName);


     //Ternary Operator
     int number = 10;
     string isNumber10 = number == 10 ? "true" : "False";
     Console.WriteLine("Number == 10 is {0}, isNumber10");*/

    //If STATEMENT (EXMPLE)
    /*int number = 10;
    if (number > 5)
    {
      Console.WriteLine("The number is greater than 5");
    }*/
    //positive and even
    /*Console.Write("Enter an integer:");

    int number = 11;

    if (number > 0)
    {
      if (number % 2 == 0)
      {
        Console.WriteLine(" Even");
      }
      else
      {
        Console.WriteLine("Odd");
      }
      if (number < 0)
      {
        Console.WriteLine("Positive");
      }
      else
      {
        Console.WriteLine("Negative");
      }
    }
    else
    {
      Console.WriteLine("Zero");
    }
    //Age
    Console.WriteLine("Enter your age");
    int age = 21;

    if (age >= 18)
    {
      Console.WriteLine("You are in adult");
    }
    else
    {
      Console.WriteLine("You are not in adult ");
    }
    //grade print
    int score = 85;
    if (score >= 90)
    {
      Console.WriteLine("Grade: A");
    }
    if (score >= 80)
    {
      Console.WriteLine("Grade: b");
    }
    else
    {
      Console.WriteLine("Fail");
    }
    //if else statement
    //{1}
    int tempreture = 30;
    if (tempreture > 30)
    {
      Console.WriteLine("It's hot outside!");
    }
    else
    {
      Console.WriteLine("It's hot outside");
    }
    //2
    int marks = 40;
    if (marks >= 70)
    {
      Console.WriteLine("You passed!");
    }
    else
    {
      Console.WriteLine("You failed");
    }
    //if else if statement {1}
    int num = 85;

    if (num >= 90)
    {
      Console.WriteLine("Grade A");
    }
    else if (num >= 80)
    {
      Console.WriteLine("Grade B");
    }
    else if (num >= 70)
    {
      Console.WriteLine("Grade C");
    }
    else if (num >= 60)
    {
      Console.WriteLine("Grade D");
    }
    else
    {
      Console.WriteLine("Fail");
    }
    //2 tempreture check
    double temp = 23.5;
    if (temp > 30.0)
    {
      Console.WriteLine("It is hot outside");
    }
    else if (temp > 20.0)
    {
      Console.WriteLine("It is warm outside");
    }
    else if (temp > 10.0)
    {
      Console.WriteLine("It cool outside");
    }
    else
    {
      Console.WriteLine("It =cold outside");
    }
    //3 example
    string username = "admin";
    string password = "secret123";

    if (username == "admin" && password == "sercret123")
    {
      Console.WriteLine("login successful! Welcome Admin.");
    }
    else if (username == "user" && password == "pass123")
    {
      Console.WriteLine("login successfull! Welcome User");
    }
    else if (username == "guest" && password == "guest123")
    {
      Console.WriteLine("login successful! Welcome Guest");
    }
    else
    {
      Console.WriteLine("Invalid credentials. Access defined");
    }*/
    //SWITCH CASE STATEMENT EXAMPLE
    /*Console.WriteLine("Enter the day number (1-7):");
    int day = Convert.ToInt32(Console.ReadLine());

    switch (day)
    {
      case 1:
        Console.WriteLine("Monday");
        break;
      case 2:
        Console.WriteLine("Tuesday");
        break;
      case 3:
        Console.WriteLine("Wednesday");
        break;
      case 4:
        Console.WriteLine("Thrusday");
        break;
      case 5:
        Console.WriteLine("Friday");
        break;
      case 6:
        Console.WriteLine("saturday");
        break;
      case 7:
        Console.WriteLine("sunday");
        break;
      default:
        Console.WriteLine("Invalid day number: Please enter a number between 1 and 7");
        break;

    }
    Console.WriteLine("Enter the grade: ");
    int student = Convert.ToInt32(Console.ReadLine());

    switch (student)
    {
      case 1:
        Console.WriteLine("Grade A");
        break;
      case 2:
        Console.WriteLine("Grade B");
        break;
      case 3:
        Console.WriteLine("Grade C");
        break;
      case 4:
        Console.WriteLine("Fail");
        break;
      default:
        Console.WriteLine(" Enter the Grade");
        break;

    }

    Console.WriteLine("Enter the divisible by 5 ");
    int number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
      case 1:
        Console.WriteLine("45 is divisible by 5");
        break;
      case 2:
        Console.WriteLine("35 is divisible by 5");
        break;
      default:
        Console.WriteLine("divisiblity number 5");
        break;

    }
    
    
      Console.WriteLine("Enter a grade (A, B, C, D, or F):");
    char grade = Convert.ToChar(Console.ReadLine().ToUpper());
        string message;
        
        switch (grade)
        {
            case 'A':
                message = "Excellent!";
                break;
            case 'B':
                message = "Good job!";
                break;
            case 'C':
                message = "Satisfactory";
                break;
            case 'D':
                message = "Needs improvement";
                break;
            case 'F':
                message = "Failed";
                break;
            default:
                message = "Invalid grade";
                break;
        }
        
        Console.WriteLine(message);*/
    //LOOPS { for loop } -{1}
    /*for (int i = 1; i >= 5; i++)
    {
      Console.WriteLine($"Current number: {i}");
    }*/
    //{2} natural number
    /*Console.WriteLine("Enter the upper limit (N):");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Natural numbers from 1 to {0}:", n);

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine(i);
    }*/
    //Even number
    /* Console.WriteLine("Enter the number upper limit:");
     int limit = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("even number from 1 to {0}:", limit);

     for (int i = 1; i <= limit; i++)
     {
       Console.WriteLine(i);
     }  */

    //sum natural number
    /*    Console.Write("Enter a positive number");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
          sum = i + 1;
          Console.WriteLine($"sum of first natural number is: {sum}");
        }*/
    //ASCII charcter
    /*Console.WriteLine("ASCII Characters (0-127):");
    Console.WriteLine("\tChar");
    for (int i = 0; i <= 127; i++)
    {
     if (i < 32 || i == 127)
            {
                Console.WriteLine($"{i}\t{i:X2}\t(Control Character)");
            }
            else
            {
                Console.WriteLine($"{i}\t{i:X2}\t{(char)i}");
            }
           
            
    }   */

    //cube of integer

    /*Console.WriteLine("Display cube of integer");
    Console.WriteLine("_____________");

    Console.Write("Enter a positive integer");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
      Console.Write("Please enter a valid positive integer:");

    }
    Console.WriteLine("\nNumber\tCube");
    Console.WriteLine("_______\t______");

    for (int i = 1; i <= number; i++)
    {
      int cube = i * i * i;
      Console.WriteLine($"{i}\t{cube}");
    }*/


    //while loop{example}-basic
    /*int b = 1;
    while (b <= 10)
    {
      Console.WriteLine("Fahad Hussian");
      b++;
    }*/

    //user input until valid
    /*string input;
    bool isValid = false;

    while (!isValid)
    {
      Console.Write("Enter yes or no");
      input = Console.ReadLine().ToLower();
      if (input == "yes" || input == "no") {
        isValid = true;
        Console.WriteLine($"You entered: {input}");
      }
      else
    {
        Console.WriteLine("Invalid input. Try again.");
    }

   }*/

    //summing numbers
    /*int sum = 0;
    int number = 1;

    while (number <= 10)
    {
      sum = sum + number;
      number++;
    }
    Console.WriteLine($"Sum of numbers from 1 to 10 is: {sum}");*/

    //infinite loop with break
    /*while (true)
    {
      Console.Write("Enter a number (0 to exist)");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num == 0)
      {
        Console.WriteLine("Existing the program");
        break;
      }
      Console.WriteLine($"You entered:  {num}");
    }*/

    //nested while loop
    /* int i = 1;
     while (i <= 3)
     {
       int j = 1;
       while (j <= 3)
       {
         Console.WriteLine($"i = {i}, j = {j}");
         j++;
       }
       i++;
     }*/
    //fibonacci sequence
    /*int a = 0, b = 1;
    int count = 0;

    Console.WriteLine("First 10 fibonacci numbers:");
    while (count < 10)
    {
      Console.WriteLine(a);
      int temp = a;
      a = b;
      b = temp + b;
      count++;
    }*/
    //factoriasl calculation
    /*int n = 5;
    int factorial = 1;
    int current = 1;

    while (current <= n)
    {
      factorial *= current;
      current++;
    }
    Console.WriteLine($"factorial of {n} is {factorial}");*/

    //do-while-true condition
    /* int c = 1;
     do
     {
       Console.WriteLine("Fahad Hussian");
       c++;
     } while (c <= 10);*/

    //false-condition
    /* int c = 12;
     do
     {
       Console.WriteLine("Fahad Hussian");
       c++;
     } while (c <= 10);*/

    //user input validation
    /* string userInput;
     do
     {
       Console.Write("Enter yes to continue:");
       userInput = Console.ReadLine().ToLower();
     } while (userInput != "yes");*/

    //sum of numbers until zero
    /* int number;
 int sum = 0;

 do 
 {
     Console.Write("Enter a number (0 to stop): ");
     number = int.Parse(Console.ReadLine());
     sum += number;
 } while (number != 0);

 Console.WriteLine($"Total sum: {sum}");*/
    //PATTERN PRINTING FOR LOOP
    //{1} *****
    //   *****
    //    *****
    //    *****

    /* int rows = 5;
     int starsPerRow = 5;

     for (int i = 0; i < rows; i++)
     {
         Console.WriteLine(new string('*', starsPerRow));
     }*/

  
    }
}
  


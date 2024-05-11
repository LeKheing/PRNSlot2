
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter method to execute(1-104): ");
        string methodName = Console.ReadLine();

        var method = typeof(Program).GetMethod("Q" + methodName);
        if (method != null)
        {
            method.Invoke(null, null);
        }
    }

    public static int checkInt(String msg)
    {
        bool check = false;
        int num = 0;
        while (!check)
        {
            Console.WriteLine(msg);
            string a = Console.ReadLine();
            try
            {
                num = Convert.ToInt32(a);
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
            }
        }
        return num;
    }

    public static string checkString(string msg)
    {
        while (true)
        {
            try
            {
                Console.WriteLine(msg);
                string s = Console.ReadLine();
                if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s))
                {
                    throw new Exception();
                }
                return s;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid string input");
            }
        }
    }

    public static double checkDouble(String msg)
    {
        bool check = false;
        double num = 0;
        while (!check)
        {
            Console.WriteLine(msg);
            string a = Console.ReadLine();
            try
            {
                num = Convert.ToDouble(a);
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
            }
        }
        return num;
    }

    public static void Q1()
    {
        Console.WriteLine("Hello!!!");
        Console.WriteLine("Le Phu Khang");
    }

    public static void Q2()
    {
        int a = checkInt("Input first number: ");
        int b = checkInt("Input second number: ");
        Console.WriteLine("Result: {0}", a + b);
    }

    public static void Q3()
    {
        int a = checkInt("Input first number: ");
        int b = checkInt("Input second number: ");
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            Console.WriteLine($"Result: {a / b}");
        }
    }

    public static void Q4()
    {
        Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
        Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
        Console.WriteLine($"14 + (-4) * 6 / 11 = {14 - 4 * 6 / 11}");
        Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 + {2 + 15 / 6 * 1 - 7 % 2}");
    }

    public static void Q5()
    {
        int a = checkInt("Input first number: ");
        int b = checkInt("Input second number: ");
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"\nFirst number after swapping: {a}");
        Console.WriteLine($"Second number after swapping: {b}");
    }

    public static void Q6()
    {
        int a = checkInt("Input first number: ");
        int b = checkInt("Input second number: ");
        int c = checkInt("Input third number: ");
        Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
    }

    public static void Q7()
    {
        double a = checkDouble("Input first number: ");
        double b = checkDouble("Input second number: ");
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
    }

    public static void Q8()
    {
        int a = checkInt("Input a number: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{a} * {i} = {a * i}");
        }
    }

    public static void Q9()
    {
        double a = checkDouble("Input first number: ");
        double b = checkDouble("Input second number: ");
        double c = checkDouble("Input third number: ");
        double d = checkDouble("Input fourth number: ");
        Console.WriteLine($"The average of {a}, {b}, {c}, {d} = {(a + b + c + d) / 4}");
    }

    public static void Q10()
    {
        int a = checkInt("Enter first number - ");
        int b = checkInt("Enter second number - ");
        int c = checkInt("Enter third number - ");
        Console.WriteLine($"Result of specified numbers {a}, {b} and {c}, (x+y).z is {(a + b) * c} and x.y + y.z is {a * b + b * c}");
    }

    public static void Q11()
    {
        int a = checkInt("Enter your age - ");
        Console.WriteLine($"You look older than {a}");
    }

    public static void Q12()
    {
        int a = checkInt("Enter a digit");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
        }
    }

    public static void Q13()
    {
        int a = checkInt("Enter a number: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == 0 || i == 4)
                {
                    Console.Write(a);
                }
                else
                {
                    if (j == 0 || j == 2)
                        Console.Write(a);
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void Q14()
    {
        double celsius = checkDouble("Enter the amount of Celsius: ");

        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("Kelvin = " + kelvin);
        Console.WriteLine("Fahrenheit = " + fahrenheit);

    }

    public static void Q15()
    {
        string str = checkString("Enter data");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(str.Remove(new Random().Next(0, str.Length - 1), 1));
        }
    }

    public static void Q16()
    {
        string str1 = checkString("Enter first data");
        string str2 = checkString("Enter second data");

        char[] charStr1 = str1.ToCharArray();
        Array.Reverse(charStr1);
        char[] charStr2 = str2.ToCharArray();
        Array.Reverse(charStr2);

        Console.WriteLine(new string(charStr1));
        Console.WriteLine(new string(charStr2));
    }

    public static void Q17()
    {
        string str = checkString("Enter string: ");
        char[] strChar = str.ToCharArray();
        str = strChar[0] + str + strChar[0];
        Console.WriteLine(str);
    }

    public static void Q18()
    {
        int a = checkInt("Enter first integer - ");
        int b = checkInt("Enter second integer - ");
        Console.WriteLine("Check if one is positive and one is negative: " + (a * b < 0));
    }

    public static void Q19()
    {
        int a = checkInt("Enter first integer - ");
        int b = checkInt("Enter second integer - ");
        Console.WriteLine(a == b ? (a + b) * 3 : (a + b));
    }

    public static void Q20()
    {
        int a = checkInt("Enter first integer - ");
        int b = checkInt("Enter second integer - ");
        if (a > b)
            Console.WriteLine((a - b) * 2);
        else Console.WriteLine(b - a);
    }

    public static void Q21()
    {
        int a = checkInt("Enter first integer - ");
        int b = checkInt("Enter second integer - ");
        int sum = a + b;
        if (a == 20 || b == 20 || sum == 20)
            Console.WriteLine(true);
        else Console.WriteLine(false);
    }

    public static void Q22()
    {
        int a = checkInt("Enter integer - ");
        if (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20)
            Console.WriteLine(true);
        else Console.WriteLine(false);
    }

    public static void Q23()
    {
        string str = checkString("Enter string: ");
        Console.WriteLine(str.ToLower());
    }

    public static void Q24()
    {
        string str = checkString("Enter string: ");
        string[] strArr = str.Split();
        string maxLen = strArr[0];
        foreach (string str2 in strArr)
        {
            if (str2.Length > maxLen.Length)
                maxLen = str2;
        }
        Console.WriteLine(maxLen);
    }

    public static void Q25()
    {
        for (int i = 1; i <= 99; i++)
            if (i % 2 != 0)
                Console.WriteLine(i);
    }

    public static Boolean checkPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static void Q26()
    {
        int count = 0, i = 0, sum = 0; ;
        while (count < 500)
        {
            if (checkPrime(i))
            {
                count++;
                sum += i;
            }
            i++;
        }
        Console.WriteLine(sum);
    }

    public static void Q27()
    {
        int a = checkInt("Enter an integer: ");
        string str = a.ToString();
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            int num = Convert.ToInt32(str[i] - '0');
            sum += num;
        }
        Console.WriteLine(sum);
    }

    public static void Q28()
    {
        string str = checkString("Enter data: ");
        string[] strArr = str.Split();
        Array.Reverse(strArr);
        foreach (string word in strArr)
        {
            Console.Write(word + " ");
        }
    }

    public static void Q29()
    {
        FileInfo f = new FileInfo("D:/abc.txt");
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }

    public static void Q30()
    {
        string hexa = checkString("Enter data");
        int decimalNumber = Convert.ToInt32(hexa, 16);

        Console.WriteLine("Decimal representation: " + decimalNumber);
    }

    public static void Q31()
    {
        int[] a1 = new int[4];
        int[] a2 = new int[4];
        int[] sum = new int[4];
        Console.WriteLine("Enter first array: ");
        for (int i = 0; i < 4; i++)
        {
            a1[i] = checkInt("Enter number " + (i + 1));
        }
        Console.WriteLine("Enter second array: ");
        for (int i = 0; i < 4; i++)
        {
            a2[i] = checkInt("Enter number " + (i + 1));
            sum[i] = a1[i] * a2[i];
        }

        Console.WriteLine("Multiply corresponding elements of two arrays:");
        for (int i = 0; i < 4; i++)
            Console.Write(sum[i] + " ");
    }

    public static void Q32()
    {
        string str = checkString("Enter data: ");
        if (str.Length < 4)
            Console.WriteLine(str);
        else
            Console.WriteLine("{0}{0}{0}{0}", str.Substring(str.Length - 4, 4));
    }

    public static void Q33()
    {
        int a = checkInt("Enter first integer");
        if (a % 3 == 0 || a % 7 == 0)
            Console.WriteLine(true);
        else Console.WriteLine(false);
    }

    public static void Q34()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }

    public static void Q35()
    {
        int a = checkInt("Input a first number(<100)");
        int b = checkInt("Input a second number(>100)");
        Console.WriteLine(a < 100 && b > 100);
    }

    public static void Q36()
    {
        int a = checkInt("Input a first number");
        int b = checkInt("Input a second number");
        Console.WriteLine(-10 < a && a < 10 && -10 < b && b < 10);
    }

    public static void Q37()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str);
    }

    public static void Q38()
    {
        string str1 = checkString("Enter data: ");

        var result = "";

        if (str1.Length >= 1 && str1[0] == 'P')
            result += str1[0];

        if (str1.Length >= 2 && str1[1] == 'H')
            result += str1[1];

        Console.WriteLine(result);
    }

    public static void Q39()
    {
        int a = checkInt("Input a first number");
        int b = checkInt("Input a second number");
        int c = checkInt("Input a third number");
        int max = a, min = a;
        if (max < b) max = b;
        if (max < c) max = c;
        if (min > b) min = b;
        if (min > c) min = c;

        Console.WriteLine("Largest of 3: " + max);
        Console.WriteLine("Lowest of 3: " + min);
    }

    public static void Q40()
    {
        int a = checkInt("Input a first number");
        int b = checkInt("Input a second number");

        int dif1 = Math.Abs(a - 20);
        int dif2 = Math.Abs(b - 20);
        if (dif1 < dif2) Console.WriteLine(a);
        if (dif2 < dif1) Console.WriteLine(b);
        if (dif1 == dif2) Console.WriteLine(0);
    }

    public static void Q41()
    {
        string str = checkString("Enter data: ");
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.ToLowerInvariant(str[i]) == 'w')
            {
                count++;
            }
        }
        if (count >= 1 && count <= 3)
            Console.WriteLine(true);
        else Console.WriteLine(false);
    }

    public static void Q42()
    {
        string str = checkString("Enter data: ");
        if (str.Length <= 4)
            Console.WriteLine(str.ToUpper());
        else
            Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
    }

    public static void Q43()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine(str.StartsWith("wwwww"));
    }

    public static void Q44()
    {
        string str = checkString("Enter data: ");
        string rs = "";
        for (int i = 0; i < str.Length; i += 2)
            rs += str[i];
        Console.WriteLine(rs);
    }

    public static void Q45()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int num = checkInt("Enter integer: ");
        int count = 0;
        for (int i = 0; i < 10; i++)
            if (a[i] == num)
                count++;
        Console.WriteLine($"Number of {num} present in the said array: {count}");
    }

    public static void Q46()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int num = checkInt("Enter integer: ");
        Console.WriteLine(a[0] == num || a[9] == num);
    }

    public static void Q47()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            a[i] = checkInt("Enter number " + (i + 1));
            sum += a[i];
        }
        Console.WriteLine(sum);
    }

    public static void Q48()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        Console.WriteLine(a[0] == a[9]);
    }

    public static void Q49()
    {
        int[] a = new int[10];
        int[] b = new int[10];
        Console.Write("Enter first array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        Console.Write("Enter second array: ");
        for (int i = 0; i < 10; i++)
            b[i] = checkInt("Enter number " + (i + 1));
        Console.WriteLine(a[0] == b[0] || a[9] == b[9]);
    }

    public static void Q50()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int num = a[0];
        for (int i = 0; i < 9; i++)
            a[i] = a[i + 1];
        a[9] = num;
        for (int i = 0; i < 10; i++)
            Console.Write(a[i] + " ");
    }

    public static void Q51()
    {
        int[] a = new int[10];
        Console.Write("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int max = a[0];
        if (max < a[a.Length - 1])
            max = a[a.Length - 1];
        Console.Write($"Highest value between first and last values of the said array: {max}");
    }

    public static void Q52()
    {
        int[] a = new int[3];
        int[] b = new int[3];
        int[] c = new int[3];
        Console.Write("Enter first array: ");
        for (int i = 0; i < 3; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        Console.Write("Enter second array: ");
        for (int i = 0; i < 3; i++)
            b[i] = checkInt("Enter number " + (i + 1));
        Console.Write("Enter third array: ");
        for (int i = 0; i < 3; i++)
            c[i] = checkInt("Enter number " + (i + 1));
        int[] rs = new int[3] { a[1], b[1], c[1] };
        Console.Write("New array: ");
        for (int i = 0; i < 3; i++)
            Console.Write(rs[i] + " ");
    }

    public static void Q53()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        bool check = false;
        for (int i = 0; i < 10; i++)
        {
            a[i] = checkInt("Enter number " + (i + 1));
            if (a[i] % 2 != 0) check = true;
        }
        Console.WriteLine(check);

    }

    public static void Q54()
    {
        int year = checkInt("Enter a year: ");

        int century = (year - 1) / 100 + 1;

        Console.WriteLine("The century of {0} is {1}.", year, century);
    }

    public static void Q55()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int max = a[0] * a[1];
        for (int i = 1; i < 9; i++)
            if (max < a[i] * a[i + 1])
                max = a[i] * a[i + 1];
        Console.WriteLine(max);
    }

    public static void Q56()
    {
        string str = checkString("Enter data: ");
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        Console.Write(new string(c).Equals(str));
    }

    public static void Q57()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int max = a[0] * a[1];
        for (int i = 1; i < 9; i++)
            if (max < a[i] * a[i + 1])
                max = a[i] * a[i + 1];
        for (int i = 0; i < 9; i++)
            if (max == a[i] * a[i + 1])
            {
                Console.WriteLine(a[i] + " " + a[i + 1]);
                break;
            }
    }

    public static void Q58()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int rs = 0;
        Array.Sort(a);
        for (int i = 0; i < 9; i++)
            rs += a[i + 1] - a[i] - 1;
        Console.WriteLine(rs);
    }

    public static void Q59()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = checkInt("Enter an integer: ");
        }
        Array.Sort(arr);
        int counter = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            counter += arr[i + 1] - arr[i] - 1;
        }
        Console.WriteLine(counter == 0);
    }

    public static void Q60()
    {
        int[][] a = new int[4][];
        int[][] b = new int[4][];

        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 4; i++)
        {
            a[i] = new int[4];
            for (int j = 0; j < 4; j++)
            {
                a[i][j] = checkInt("Enter number " + (i + 1) + "," + (j + 1));
            }
        }
        b[0] = new int[4];
        for (int i = 1; i < 4; i++)
        {
            b[i] = new int[4];
            for (int j = 0; j < 4; j++)
            {
                if (a[i - 1][j] == 0)
                {
                    b[i][j] = 0;
                }
                else
                {
                    b[i][j] = a[i][j];
                }
            }
        }

        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (b[i][j] > 0)
                {
                    sum += b[i][j];
                }
            }
        }

        Console.WriteLine(sum);
    }

    public static void Q61()
    {
        int[] a = new int[5];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 5; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int[] num = a.Where(x => x != -5).OrderBy(x => x).ToArray();
        int count = 0;
        int[] rs = a.Select(x => x != -5 ? num[count++] : -5).ToArray();
        for (int i = 0; i < 5; i++)
            Console.Write(rs[i] + " ");
    }

    public static void Q62()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine(reverse_remove_parentheses(str));
    }
    public static string reverse_remove_parentheses(string str)
    {
        int lid = str.LastIndexOf('(');

        if (lid == -1)
        {
            return str;
        }
        else
        {
            int rid = str.IndexOf(')', lid);
            return reverse_remove_parentheses(
                str.Substring(0, lid) +
                new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                str.Substring(rid + 1)
            );
        }

    }

    public static void Q63()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int n = checkInt("Enter check number");
        Console.WriteLine(a.Contains(n));
    }

    public static void Q64()
    {
        string file_path;

        file_path = "d:/abc.txt";
        Console.WriteLine(file_path.Split('/').Last());  
    }

    public static void Q65()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        int[] rs = a.Select(x => x*10).ToArray();
        for (int i = 0; i < 10; i++)
            Console.WriteLine(rs[i] + " ");
    }

    public static void Q66()
    {
        string num1 = checkString("Enter num1: ");
        string num2 = checkString("Enter num2: ");

        Console.WriteLine(Int32.Parse(num1) > Int32.Parse(num2) ? num2 : num1);
    }

    public static void Q67()
    {
        string str1 = checkString("Enter data: ");
        Console.Write(str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8"));
    }

    public static void Q68()
    {
        string str = checkString("Enter data: ");
        char uc = 'E', lc = 'e';
        Console.WriteLine(str.Split(uc, lc).Length - 1);
    }

    public static void Q69()
    {
        string str1 = checkString("Enter data: ");
        Console.WriteLine(str1 == str1.ToUpper() || str1 == str1.ToLower());
    }

    public static void Q70()
    {
        string str1 = checkString("Enter data");
        Console.WriteLine(str1.Length > 2 ? str1.Substring(1, str1.Length - 2) : str1);
    }

    public static void Q71()
    {
        string str = checkString("Enter data");
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                Console.WriteLine(true);
                return;
            }
        }
        Console.WriteLine(false);
    }

    public static void Q72()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        Console.WriteLine(a.Average() % 1 == 0);
    }

    public static void Q73()
    {
        string str = checkString("Enter data: ");
        
        Console.WriteLine(str.OrderBy(x => x.ToString()).ToArray());
    }

    public static void Q74()
    {
        string str = checkString("Enter data: ");
        Console.Write(str.Length % 2 == 0? "Even" : "Odd");
    }

    public static void Q75()
    {
        int num = checkInt("Ente an integer");
        int count = 0;
        int i = 0;
        while (count < num)
        {
            if (i % 2 != 0)
                count++;
            i++;
        }
        Console.WriteLine(i - 1);
    }

    public static void Q76()
    {
        Console.WriteLine("Enter data");
        char str =  Convert.ToChar(Console.ReadLine());
        Console.Write((int)str);
    }

    public static void Q77()
    {
        string str = checkString("Enter data");
        Console.WriteLine(str.EndsWith("s"));
    }

    public static void Q78()
    {
        int[] a = new int[10];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 10; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        Console.WriteLine(a.Sum(x => x*x));
    }

    public static void Q79()
    {
        string n_str = "50";

        Console.WriteLine("Original value and type: " + n_str + ",  " + n_str.GetType());
        int result = Convert.ToInt32(n_str);

        Console.WriteLine("Convert string to integer:");
        Console.WriteLine("Return value and type: " + result + ",  " + result.GetType());

        int n = 122;
        Console.WriteLine("\nOriginal value and type: " + n + ",  " + n.GetType());

        string result1 = Convert.ToString(n);

        Console.WriteLine("Convert integer to string:");
        Console.WriteLine("Return value and type: " + result1 + ",  " + result1.GetType());
    }

    public static void Q80()
    {
        object[] a = new object[5];
        a[0] = 25; 
        a[1] = "Anna"; 
        a[2] = false; 
        a[3] = System.DateTime.Now; 
        a[4] = 112.22;
        string[] rs = Array.ConvertAll(a, x => x.ToString());
        Console.WriteLine("Printing original array elements and their types:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Value-> " + a[i] + " :: Type-> " + a[i].GetType());
        }

        Console.WriteLine("\nPrinting array elements and their types after conversion:");
        for (int i = 0; i < rs.Length; i++)
        {
            Console.WriteLine("Value-> " + rs[i] + " :: Type-> " + rs[i].GetType());
        }
    }

    public static void Q81()
    {
        int a = checkInt("Enter a number: ");
        string str = new string(a.ToString().ToCharArray().Reverse().ToArray());
        Console.WriteLine(a >= Convert.ToInt32(str));
    }

    public static void Q82()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine(Regex.Replace(str, @"[^a-zA-Z]", ""));
    }

    public static void Q83()
    {
        string str = checkString("Enter data: ");
        Console.WriteLine(Regex.Replace(str, @"[ueoai]", ""));
    }

    public static void Q84()
    {
        string str = checkString("Enter data: ");
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLower(str[i]))
                Console.Write(i + " ");
        }
    }

    public static void Q85()
    {
        int[] a = new int[5];
        int[] sum = new int[5];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < 5; i++)
            a[i] = checkInt("Enter number " + (i + 1));
        sum[0] = a[0];
        for (int i = 1; i < 5; i++)
            sum[i] = a[i] + sum[i-1];
        for (int i = 0; i < 5; i++)
            Console.Write(sum[i] + " ");
    }

    public static void Q86()
    {
        string str = checkString("Enter data");
        int countD = 0;
        int countL = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
                countL++;
            if (char.IsDigit(str[i]))
                countD++;
        }
        Console.WriteLine("Number of digit: " + countD);
        Console.WriteLine("Number of letter: " + countL);
    }

    public static void Q87()
    {
        bool a = true;
        bool b = false;
        Console.WriteLine(!a);
        Console.WriteLine(!b);
    }

    public static void Q88()
    {
        int a = checkInt("Enter a number");
        Console.WriteLine("Sum of interior angles: " + (180*(a-2)));
    }

    public static void Q89()
    {
        int[] a = new int[5];
        Console.WriteLine("Enter array: ");
        int countP = 0, countN = 0;
        for (int i = 0; i < 5; i++) 
        { 
            a[i] = checkInt("Enter number " + (i + 1));
            if (a[i] >= 0) countP++;
            else countN++;
        }
        Console.WriteLine($"Poisitive: {countP}\n" +
            $"Negative: {countN}");
    }

    public static void Q90()
    {
        int a = checkInt("Enter a number: ");
        int ones = Convert.ToString(a,2).Count(x => x == '1');
        int zeros = Convert.ToString(a, 2).Count(x => x == '0');
        Console.WriteLine("Number of 1: " + ones);
        Console.WriteLine("Number of 0: " + zeros);
    }

    public static void Q91()
    {
        object[] mixedArray = new object[6];
        mixedArray[0] = 25;
        mixedArray[1] = "Anna";
        mixedArray[2] = false;
        mixedArray[3] = System.DateTime.Now;
        mixedArray[4] = -112;
        mixedArray[5] = -34.67;
        int[] num = mixedArray.OfType<int>().ToArray();

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    }

    public static void Q92()
    {
        int a = checkInt("Enter a number");
        if (checkPrime(a))
        {
            Console.Write(a);
            return;
        }
        while (true)
        {
            a++;
            if (checkPrime(a))
            {
                Console.Write(a);
                return;
            }
        }
    }

    public static void Q93()
    {
        int a = checkInt("Enter a number");
        int sq = 1;

        while (sq < a / sq)
        {
            sq++;
        }
        if (sq > a / sq)
            Console.Write(sq - 1);
        else
            Console.Write(sq);
    }

    public static void Q94()
    {
        string[] str = { "Jacket", "Joint", "Junky", "Jet" };
        if (str.Length == 0 || Array.IndexOf(str, "") != -1)
        {
            Console.Write(-1);
            return;
        }

        string result = str[0];
        int i = result.Length;


        foreach (string word in str)
        {
            int j = 0;


            foreach (char c in word)
            {
    
                if (j >= i || result[j] != c)
                    break;
                j += 1;
            }

            i = Math.Min(i, j);
        }


        Console.WriteLine(result.Substring(0, i));
    }

    public static void Q95()
    {
        String str = checkString("Enter data");
        Stack<char> ch = new Stack<char>();

        foreach (var item in str.ToCharArray())
        {

            if (item == '(')
                ch.Push(')');
            else if (item == '<')
                ch.Push('>');
            else if (item == '[')
                ch.Push(']');
            else if (item == '{')
                ch.Push('}');
            else if (ch.Count == 0 || ch.Pop() != item)
            {
                Console.WriteLine(false);
                return; 
            }
        }

        Console.WriteLine( ch.Count == 0);
    }

    public static void Q96()
    {
        string str = checkString("Enter data: ");
        for (int i = 0; i < str.Length-1; i++)
            if (str[i] != str[i+1])
            {
                Console.WriteLine(false); return;
            }
        Console.WriteLine(true);
    }

    public static void Q97()
    {
        string num = checkString("Enter data");
        double rs;
        Console.WriteLine(double.TryParse(num,out rs));
    }

    public static void Q98()
    {
        int num = 2;
        while (num < 9999)
        {
            if (checkPrime(num) && checkDigitDesc(num))
                Console.Write(num + " ");
            num++;
        }
        
    }

    public static bool checkDigitDesc(int n)
    {
        if (n < 10) return true;
        string str = Convert.ToString(n);
        for (int i = 0; i < str.Length-1; i++) 
        {
            if (str[i] <= str[i + 1])
                return false;
        }
        return true;
    }

    public static bool checkDigitAsc(int n)
    {
        if (n < 10) return true;
        string str = Convert.ToString(n);
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] >= str[i + 1])
                return false;
        }
        return true;
    }

    public static void Q99()
    {
        int num = 2;
        while (num < 9999)
        {
            if (checkPrime(num) && checkDigitAsc(num))
                Console.Write(num + " ");
            num++;
        }
    }

    public static void Q100()
    {
        object text1 = "AAA";
        object text2 = "BBB";

        Console.WriteLine(text1.Equals(text2) && text1.GetType().Equals(text2.GetType()));
    }

    public static void Q101()
    {
        const double EPSILON = 1.0e-15;
        ulong fact = 1;          
        double e = 2.0;         
        double e0;        
        uint n = 2;             

        do
        {
            e0 = e;             // Store the current value of 'e' in 'e0'
            fact *= n++;        
            e += 1.0 / fact;    
        } while (Math.Abs(e - e0) >= EPSILON); 

        Console.WriteLine("e = {0:F15}", e);
    }

    public static void Q102()
    {
        int n = checkInt("Enter a number");
        int[][] a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            a[i] = new int[n];
            Array.Fill(a[i],0);
            a[i][i] = 1;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(a[i][j] + " ");
            Console.WriteLine();
        }
    }

    public static void Q103()
    {
        string str = checkString("Enter data");
        if (string.IsNullOrEmpty(str))
            Console.WriteLine("Blank!");
        else
        {
            char[] arr = str.ToCharArray().OrderBy(x => char.ToLower(x)).ToArray();
            Console.WriteLine(new string(arr));
        }
    }

    public static void Q104()
    {
        int a, b, c;
        a = checkInt("Enter first number: ");
        b = checkInt("Enter second number: ");
        c = checkInt("Enter third number: ");

        Console.Write((a == b && b == c) ? 3 : (a != b && b != c && a != c) ? 0 : 2);
    }

}


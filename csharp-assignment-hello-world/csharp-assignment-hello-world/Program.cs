using System;
using System.Globalization;
public class Program
{
    static void Main(string[] args)
    {
        // 1. Calculator
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operation (+, -, *, x, /): ");
        string op = Console.ReadLine();

        double result = 0;
        switch (op)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*":
            case "x": result = num1 * num2; break;
            case "/": result = num2 != 0 ? num1 / num2 : double.NaN; break;
            default: Console.WriteLine("Invalid operation."); break;
        }
        Console.WriteLine("Result: " + result);

        // 2. Display x = y^2 + 2y + 1 for y = -5 to 5
        Console.WriteLine("\nValues of x = y^2 + 2y + 1 for y = -5 to 5:");
        for (int yy = -5; yy <= 5; yy++)
        {
            int xx = yy * yy + 2 * yy + 1;
            Console.WriteLine($"y = {yy}, x = {xx}");
        }

        // 3. Speed calculation
        Console.Write("\nEnter distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double totalHours = hours + minutes / 60.0 + seconds / 3600.0;
        double speedKmh = distance / totalHours;
        double speedMph = speedKmh / 1.609344;
        Console.WriteLine($"Speed: {speedKmh:F2} km/h, {speedMph:F2} miles/h");

        // 4. Sphere surface and volume
        Console.Write("\nEnter radius of sphere: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Surface area: {surface:F2}");
        Console.WriteLine($"Volume: {volume:F2}");

        // 5. Character check
        Console.Write("\nEnter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if ("aeiouAEIOU".IndexOf(ch) >= 0)
            Console.WriteLine("Vowel");
        else if (char.IsDigit(ch))
            Console.WriteLine("Digit");
        else
            Console.WriteLine("Other symbol");

        // 6. Check even or odd
        Console.Write("Enter a number to check even/odd: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");

        // 7. Find largest of three numbers
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int largest = a;
        if (b > largest) largest = b;
        if (c > largest) largest = c;
        Console.WriteLine("Largest: " + largest);

        // 8. Determine quadrant of a coordinate point
        // Nhập giá trị X và Y
        Console.Write("Input the value for X coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for Y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        // Kiểm tra tọa độ nằm ở đâu
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies at the Origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
        }
        else if (y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
        }

        // 9. Check triangle type
        Console.Write("Enter side 1: ");
        int s1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 2: ");
        int s2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 3: ");
        int s3 = Convert.ToInt32(Console.ReadLine());
        if (s1 == s2 && s2 == s3)
            Console.WriteLine("Equilateral triangle");
        else if (s1 == s2 || s2 == s3 || s1 == s3)
            Console.WriteLine("Isosceles triangle");
        else
            Console.WriteLine("Scalene triangle");

        // 10. Read 10 numbers, find sum and average
        int sum = 0;
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + (sum / 10.0));

        // 11. Print multiplication table of 7
        Console.WriteLine("Multiplication table of 7:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"7 x {i} = {7 * i}");
        }
        Console.WriteLine("End of program.");

        // 12. Print patterns
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPattern A:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }
        Console.WriteLine("\nPattern B:");
        int cur = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(cur++ + " ");
            Console.WriteLine();
        }
        Console.WriteLine("\nPattern C:");
        cur = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s <= (n - i) * 2; s++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write(cur++ + " ");
            Console.WriteLine();
        }

        // 13. Calculate sum of series 1 + 1/2 + 1/3 + ... + 1/n
        Console.Write("Enter n: ");
        int nn = int.Parse(Console.ReadLine()!);
        double sum1 = 0.0;
        for (int i = 1; i <= nn; i++)
        {
            sum1 += 1.0 / i;
            Console.Write(i == 1 ? "1" : $" + 1/{i}");
        }
        Console.WriteLine();
        Console.WriteLine($"Sum = {sum1.ToString("F6", CultureInfo.InvariantCulture)}");

        // 14. Find perfect numbers in range [L, R]
        Console.Write("Enter L: ");
        int L = int.Parse(Console.ReadLine());
        Console.Write("Enter R: ");
        int R = int.Parse(Console.ReadLine());

        bool found = false;
        for (int number = L; number <= R; number++)
        {
            int perfectSum = 0;
            for (int d = 1; d < number; d++)
            {
                if (number % d == 0)
                    perfectSum += d;
            }
            if (perfectSum == number && number > 1)
            {
                Console.WriteLine(number);
                found = true;
            }
        }
        if (!found) Console.WriteLine("No perfect numbers in range.");

        // 15. Check if a number is prime
        Console.Write("Enter number: ");
        int nguyento = int.Parse(Console.ReadLine());
        bool prime = true;
        if (nguyento < 2) prime = false;
        else
        {
            for (int d = 2; d <= Math.Sqrt(nguyento); d++)
            {
                if (nguyento % d == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        if (prime) Console.WriteLine(nguyento + " is Prime");
        else Console.WriteLine(n + " is Not Prime");
    }
}
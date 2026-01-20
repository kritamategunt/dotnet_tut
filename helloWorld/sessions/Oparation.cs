public class Operation
{

    private int getSumPrivate(int x, int y)
    {
        return x + y;
    }
    public int getSumPublic(int x, int y)
    {
        return x + y;
    }

    static int getSumStatic(int x, int y)
    {
        return x + y;
    }
    public void Execute()
    {
        // Implementation here
        //Operation in dotnet
        getSumPrivate(5, 10);
        int a = 10;
        int b = 20;
        int myVar = 15;

        myVar += 5; // Equivalent to myVar = myVar + 5
        System.Console.WriteLine("myVar after += 5: " + myVar+"while myVar initial is "+(myVar-5));
        int sum = a + b;
        System.Console.WriteLine("\nSum: " + sum);

        int difference = b - a;
        System.Console.WriteLine("Difference: " + difference);

        int product = a * b;
        System.Console.WriteLine("Product: " + product);

        double quotient = (double)b / a;
        System.Console.WriteLine("Quotient: " + quotient);

        int remainder = b % a;
        System.Console.WriteLine("Remainder: " + remainder);

        int incrementA = ++a; // Pre-increment
        System.Console.WriteLine("Pre-increment A: " + incrementA);

        int decrementB = --b; // Pre-decrement
        System.Console.WriteLine("Pre-decrement B: " + decrementB);

        int postIncrementA = a++; // Post-increment
        System.Console.WriteLine("Post-increment A: " + postIncrementA + ", New A: " + a);

        int postDecrementB = b--; // Post-decrement
        System.Console.WriteLine("Post-decrement B: " + postDecrementB + ", New B: " + b);

        System.Console.WriteLine("Math.Pow(a, 2): " + Math.Pow(a, 2));
        System.Console.WriteLine("Math.Sqrt(4): " + Math.Sqrt(4));

        //+= with strings
        string greeting = "Hello";
        greeting += ", World!";
        System.Console.WriteLine("Greeting: " + greeting);

        //sprting interpolation
        string name = "Alice";
        int age = 30;
        string info = $"Name: {name}, Age: {age}";
        System.Console.WriteLine("Info: " + info);

        //split string
        string fruits = "Apple,Banana,Cherry";
        string[] fruitArray = fruits.Split(',');
        System.Console.WriteLine("Fruits:");
        foreach (string fruit in fruitArray)
        {
            System.Console.WriteLine(fruit);
        }

        //.equals
        string str1 = "test";
        string str2 = "Test";
        bool areEqual = str1.Equals(str2);
        bool areEqualIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        System.Console.WriteLine("Are str1 and str2 equal (case-sensitive)? " + areEqual);
        System.Console.WriteLine("Are str1 and str2 equal? " + areEqualIgnoreCase);

        //and also
        //logical operators
        bool x = true;
        bool y = false;
        System.Console.WriteLine("x AND y: " + (x && y));
        System.Console.WriteLine("x OR y: " + (x || y));
        System.Console.WriteLine("NOT x: " + (!x));

        //Ternary operator
        int number = 10;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        System.Console.WriteLine("The number is: " + result);

        //comparison operators
        int num1 = 5;
        int num2 = 10;
        System.Console.WriteLine("num1 == num2: " + (num1 == num2));
        System.Console.WriteLine("num1 != num2: " + (num1 != num2));
        System.Console.WriteLine("num1 > num2: " + (num1 > num2));
        System.Console.WriteLine("num1 < num2: " + (num1 < num2));
        System.Console.WriteLine("num1 >= num2: " + (num1 >= num2));
        System.Console.WriteLine("num1 <= num2: " + (num1 <= num2));
    }

}
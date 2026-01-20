public class BasicConcept
{
    public void ShowConcepts()
    {
        // Implementation of basic concepts
        System.Console.WriteLine("This is a basic concept demonstration.");
        string message = "Hello, World!";
        string upperMessage = message.ToUpper();

        // Check if the message contains "WORLD"
        if (upperMessage.Contains("WORLD"))
        {
            System.Console.WriteLine("The message contains 'WORLD'");
        }
        else
        {
            System.Console.WriteLine("The message does not contain 'WORLD'");
        }

        //switch case example
        int day = 3;
        string dayName;
        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day";
                break;
        }
        System.Console.WriteLine("Day " + day + " is " + dayName);

        string myFirstValue = "some words";
        string mySecondValue = "Some Words";
        bool areEqual = string.Equals(myFirstValue, mySecondValue, StringComparison.OrdinalIgnoreCase);
        System.Console.WriteLine("Are the two strings equal (case-insensitive)? " + areEqual);
        switch (myFirstValue.ToLower())
        {
            case "some words":
                System.Console.WriteLine("Matched 'some words'");
                break;
            case "other words":
                System.Console.WriteLine("Matched 'other words'");
                break;
            default:
                System.Console.WriteLine("No match found");
                break;
        }

        //looping through array
        string[] colors = { "Red", "Green", "Blue" };
        System.Console.WriteLine("Colors in the array:");
        foreach (string color in colors)
        {
            System.Console.WriteLine(color);
        }

        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        //for loop, most flexible but slowest
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        System.Console.WriteLine("Sum of numbers: " + sum);
        sum = 0;//reset sum
        //foreach loop, fastest but less flexible
        foreach (int number in numbers)
        {
            sum += number;
        }
        System.Console.WriteLine("Sum of numbers from foreach :  " + sum);

        sum = 0; //reset sum
        int index = 0;
        //while loop, medium speed and flexible
        while (index < numbers.Length)
        {
            sum += numbers[index];
            index++;
        }
        System.Console.WriteLine("Sum of numbers from while loop: " + sum);

        //do while loop
        //quite fast but less used
        sum = 0; //reset sum
        index = 0;
        do
        {
            sum += numbers[index];
            index++;
        } while (index < numbers.Length);
        System.Console.WriteLine("Sum of numbers from do-while loop: " + sum);

        //also .sum method from LINQ
        //slowest but easiest
        // sum = numbers.Sum();
        // System.Console.WriteLine("Sum of numbers from LINQ .Sum(): " + sum);

        // System.Console.WriteLine("variables and data types in C#");
        Variable variable = new Variable();
        // variable.DeclareVariables();

        // System.Console.WriteLine("Hello from Operation class:");
        Operation operation = new Operation();
        operation.getSumPublic(5, 10);
        operation.Execute();


        System.Console.WriteLine("Hello from BasicConcept class:");
        BasicConcept basicConcept = new BasicConcept();
        basicConcept.ShowConcepts();
        System.Console.WriteLine("Hello from Loops class:" + basicConcept.getSum(new int[] { 1, 2, 3, 4, 5 }));

        //excise loops
        List<int> myNumberList = new List<int>(){
                2, 3, 5, 6, 7, 9, 10, 123, 324, 54
            };
        // System.Console.WriteLine("Numbers in myNumberList:");
        // foreach (int num in myNumberList)
        // {
        //     System.Console.WriteLine(num);
        // }

        //int index = 0;
        //     while(index<myNumberList.Count){
        //         totalSum+=myNumberList[index];
        //         index++;
        //     }
        // System.Console.WriteLine("Total Sum from myNumberList: " + totalSum);

        // while (index < myNumberList.Count)
        // {
        //     if (myNumberList[index] % 2 == 0)
        //     {
        //         System.Console.WriteLine(myNumberList[index]);
        //         index++;

        //     }
        //     else
        //     {
        //         index++;
        //         continue;
        //     }
        // }
    }

    public int getSum(int[] ints)
    {
        System.Console.WriteLine("Getting sum from BasicConcept class...");
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;
        }
        return sum;
    }
}
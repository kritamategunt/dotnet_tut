public class Variable
{
    public void DeclareVariables()
    {
        // Implementation of basic concepts
        System.Console.WriteLine("This is a basic Variable demonstration.");
        System.Console.WriteLine("Hello, World!");
        //System.Console.WriteLine(args.Length);


        //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
        // //// Each bit can be worth 0 or 1 of the value it is placed in
        // ////// From the right we start with a value of 1 and double for each digit to the left
        // //// 00000000 = 0
        // //// 00000001 = 1
        // //// 00000010 = 2
        // //// 00000011 = 3
        // //// 00000100 = 4
        // //// 00000101 = 5
        // //// 00000110 = 6
        // //// 00000111 = 7
        // //// 00001000 = 8

        // 1 byte (8 bit) unsigned, where signed means it can be negative
        byte myByte = 255;
        byte mySecondByte = 0;

        // 1 byte (8 bit) signed, where signed means it can be negative
        sbyte mySbyte = 127;
        sbyte mySecondSbyte = -128;


        // 2 byte (16 bit) unsigned, where signed means it can be negative
        ushort myUshort = 65535;

        // 2 byte (16 bit) signed, where signed means it can be negative
        short myShort = -32768;

        // 4 byte (32 bit) signed, where signed means it can be negative
        int myInt = 2147483647;
        int mySecondInt = -2147483648;

        // 8 byte (64 bit) signed, where signed means it can be negative
        long myLong = -9223372036854775808;


        // 4 byte (32 bit) floating point number
        float myFloat = 0.751f;
        float mySecondFloat = 0.75f;

        // 8 byte (64 bit) floating point number
        double myDouble = 0.751;
        double mySecondDouble = 0.75d;

        // 16 byte (128 bit) floating point number
        decimal myDecimal = 0.751m;
        decimal mySecondDecimal = 0.75m;

        // Console.WriteLine(myFloat - mySecondFloat);
        // Console.WriteLine(myDouble - mySecondDouble);
        // Console.WriteLine(myDecimal - mySecondDecimal);



        string myString = "Hello World";
        // Console.WriteLine(myString);
        string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
        // Console.WriteLine(myStringWithSymbols);

        bool myBool = true;


        //string[] myStringArray = new string[] { "Hello", "World", "from", "an", "array" };
        string[] myStringArray = ["Hello", "World", "from", "an", "array"];
        for (int i = 0; i < myStringArray.Length; i++)
        {
            if (i != 0)
            {
                System.Console.Write(" ");
            }
            if (myStringArray[i] == "World")
            {
                myStringArray[i] = "🌏";
            }
            System.Console.Write(myStringArray[i]);
        }

        List<string> myStringList = new List<string>();
        IEnumerable<string> myStringEnumerable = myStringList;
        System.Console.WriteLine("Is myStringEnumerable same as myStringList: " + myStringEnumerable.Equals(myStringList));
        List<string> anotherStringList = myStringEnumerable.ToList();
        System.Console.WriteLine("Is anotherStringList same as myStringList: " + anotherStringList.Equals(myStringList));


        myStringList.Add("Hello");
        myStringList.Add("World");

        for (int i = 0; i < myStringList.Count; i++)
        {
            if (i != 0)
            {
                System.Console.Write(" ");
            }
            if (i == myStringList.Count)
            {
                myStringList[i] = "🌏";
            }
            System.Console.Write(myStringList[i]);
        }

        //Multi-dimensional array
        int[,] myMultiDimensionalArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        string[,] myStringMultiDimensionalArray = { { "Hello", "World" }, { "from", "array" } };
        //3 dimensional array


        int[,,] myThreeDimensionalArray = new int[2, 2, 2]
        {
    {
        {1,2}, {3,4}
        },
    {
        {5,6}, {7,8}
         }
             };

        //Dictionary
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);



        foreach (var kvp in myDictionary)
        {
            System.Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }




        for (int i = 0; i < myMultiDimensionalArray.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < myMultiDimensionalArray.GetLength(1); j++)
            {
                System.Console.Write(myMultiDimensionalArray[i, j] + " ");
            }
        }

        for (int i = 0; i < myThreeDimensionalArray.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < myThreeDimensionalArray.GetLength(1); j++)
            {
                System.Console.WriteLine();
                for (int k = 0; k < myThreeDimensionalArray.GetLength(2); k++)
                {
                    System.Console.Write(myThreeDimensionalArray[i, j, k] + " ");
                }
            }
        }
    }
}
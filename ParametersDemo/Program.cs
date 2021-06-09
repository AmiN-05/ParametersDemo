using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass by value test");
            int testVal1 = 1;
            Console.WriteLine("Original value: {0}", testVal1);
            Test(testVal1);
            Console.WriteLine("Returned value: {0}", testVal1);

            Console.WriteLine("\nPass in a reference type test: ");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine("Original Value: {0}", testArray[0]);
            TestArray(testArray);
            Console.WriteLine("Returned value: {0}", testArray[0]);

            int testVal2;
            Console.WriteLine("\n");
            TestOut(out testVal2);
            Console.WriteLine("Returned value: {0}", testVal2);

            int testVal3 = 3;
            TestRef(ref testVal3);
            Console.WriteLine("Returned value {0}", testVal3);

            Console.WriteLine("\nCalling TestOptional with a parameter");
            TestOptional();

            Console.WriteLine("\nTestMultiple set just 2");
            TestMultiple(1, 3);

            Console.WriteLine("\nTestMultiple first and third");
            TestMultiple(1, cValue: 3);

            Console.WriteLine("Test overloaded method with string");
            TestOverloaded("Test with string");
            Console.WriteLine("Test overloaded method with numbers");
            TestOverloaded(5, 5.5);

        }
        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In test value is {0}", aValue);
        }
        public static void TestArray(int[] anArray)
        {
            anArray[0] = 111;
            Console.WriteLine("Test value is {0}", anArray[0]);
        }
        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }
        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("In TestRef Value is {0}", aValue);
        }
        public static void TestOptional(int aValue = 444)
        {
            Console.WriteLine("In Test Optional Value is {0}", aValue);
        }
        public static void TestMultiple(int aValue, int bValue = 222, int cValue =333)
        {
            Console.WriteLine("Inside TestMultiple -"
                + "Values: "
                + "{0}, {1}, {2}", aValue, bValue, cValue);
        }
        public static void TestOverloaded(string strParam)
        {
            Console.WriteLine("String overload called with a value of {0}", strParam);
        }
        public static void TestOverloaded(int intParam, double dblParam)
        {
            Console.WriteLine("Numeric Overload called with values of {0} and {1}", intParam, dblParam);
        }
    }
}

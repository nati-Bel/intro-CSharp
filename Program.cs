using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hola mundo
            /*hola
            mundo*/
            Console.WriteLine("Hello, C#!");

            string myString = "This is a string";
            myString = "Here I'm changing this variable's value";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt +4 ;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            bool myBool = true;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "My dynamic data";
            Console.WriteLine(myDynamic);

            var myVar = "An inferred-type variable";
            //myVar = 6; Error
            Console.WriteLine(myVar);

            //Interpolation
            Console.WriteLine($"My integer's value is {myInt} and boolean's {myBool}");

            const string MyConst = "My constant";
            Console.WriteLine(MyConst);

            
            //STUCTURES

            var myArray = new string[] {"Suni", "Chewie", "Rico"};
            Console.WriteLine(myArray[2]);
            myArray[2] = "Kai";
            Console.WriteLine(myArray[2]);

            //structure key:value
            var myDictionary = new Dictionary<string, int>
            {
                {"Nati", 35},
                {"Fon", 41}
            };

            Console.WriteLine(myDictionary["Nati"]);

            //a set is an unordered structures, if a value is repeated it is ignored
            var mySet = new HashSet<string> {"nati", "fon", "suni","nati", "fon", "suni"};
            Console.WriteLine(mySet);

            var myTuple = ("nati", "fon", "suni");
            Console.WriteLine(myTuple);

            //LOOPS

            for (int index = 0; index < 10; index++)
            {
                //Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //FLOWS

            if (myInt==11 && myBool == true)
            {
                Console.WriteLine("The value is 11");
            }
            else if (myInt==12 || myBool == false)
            {
                Console.WriteLine("The value is 12");
            }
            else
            {   
                Console.WriteLine("The value is not 11 neither 11");
            }

            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            var myClass = new MyClass("Nati");
            myClass.myName = "Natalinka";
            Console.WriteLine(myClass.myName);

        }

        static void MyFunction()
            {
                Console.WriteLine("My function");
            }
        static int MyFunctionWithReturn(int param)
            {
                return 10 + param;
            }
        class MyClass
        {
            public string myName {get; set; }

            public MyClass(string myCurrentName)
            {
                myName = myCurrentName;
            }
        }
    }
}



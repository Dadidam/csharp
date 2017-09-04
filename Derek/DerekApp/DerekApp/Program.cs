using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekApp
{
    class DiffTypes
    {
        public void DisplayTypes()
        {
            // bool type
            bool canVote = true;

            // char type, e.g. in Unicode
            char grade = '\u0040';

            // Integer with max number of 2,147,483,647 
            int maxInt = int.MaxValue;

            // Long with max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need smth bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A double is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            // variable w/o type
            var anotherName = "Tom";
            var anotherNumber = 98765;
            var anotherFloat = 3.14;

            Console.WriteLine("Type of {0} — {1}", anotherName, anotherName.GetTypeCode());
            Console.WriteLine("Type of {0} — {1}", anotherNumber, anotherNumber.GetTypeCode());
            Console.WriteLine("Type of {0} — {1}", anotherFloat, anotherFloat.GetTypeCode());
        }
    }

    class RandomValue
    {
        public void GetRandomValue()
        {
            // Get a random number in some range
            Random rand = new Random();
            Console.WriteLine("Random number between 0 and 100 is: " + (rand.Next(0, 100)));
        }
    }

    class MathActions
    {
        public void ShowMeThePowerOfMath()
        {
            int i = 0;

            /* 
             * 
             * 1) Increment/decrement
             * 
             * Attention! Increment value after action if i++
             * 
             */
            Console.WriteLine("i++ = " + i++); // == 0
            Console.WriteLine("++i = " + ++i); // == 2
            Console.WriteLine("i-- = " + i--); // == 2
            Console.WriteLine("--i = " + --i); // == 0

            /*
             * 
             * 2) Cast (format) types
             * 
             */
            double pi = 3.14;
            int intPi = (int)pi;

            Console.WriteLine("");
            Console.WriteLine("pi value is: " + pi + ", but (int)pi is equal to: " + intPi);

            /*
             * 
             * 3) Floor and ceil value, absolute and etc.
             * 
             */
            double num1 = 10.5;
            double num2 = 17;

            Console.WriteLine("");
            Console.WriteLine("Math.Abs({0}) == {1}", num1, (Math.Abs(num1)));
            Console.WriteLine("Math.Ceiling({0}) == {1}", num1, (Math.Ceiling(num1)));
            Console.WriteLine("Math.Floor({0}) == {1}", num1, (Math.Floor(num1)));
            Console.WriteLine("Math.Max({0},{1}) == {2}", num1, num2, (Math.Max(num1, num2)));
            Console.WriteLine("Math.Min({0},{1}) == {2}", num1, num2, (Math.Min(num1, num2)));
            Console.WriteLine("Math.Pow({0}) == {1}", num1, (Math.Pow(num1, 2)));
            Console.WriteLine("Math.Round({0}) == {1}", num1, (Math.Round(num1)));
        }
    }

    class LogicalRelations
    {
        public void LogicExample()
        {
            int age = 17;

            /*
             * 
             * 1) If-elseIf-else implementation + logical '&&'
             * 
             * We can use for if-else short entry without {} 
             * if instruction consist of only 1-string
             * 
             */
            if ((age >= 5) && (age <= 7))
                Console.WriteLine("Go to Elementary school");
            else if ((age > 7) && (age < 13))
                Console.WriteLine("Go to Middle school");
            else
                Console.WriteLine("Go to High school");

            /*
             * 
             * 2) Logial OR operator
             * 
             */
            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            /*
             * 
             * 3) Ternary operator
             * 
             */
            bool canDrive = age >= 16 ? true : false;

            /*
             * 
             * 4) Switch operator
             * 
             */
            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            Cute:
            Console.WriteLine("Toddlers are SO CUTE!");
        }
    }

    class Loops
    {
        public void LoopExamples()
        {
            int i = 0;

            /*
             * 
             * 1) WHILE
             * 
             */
            Console.WriteLine("\nwhile loop example:");
            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }

                // break (stop) a loop
                if (i == 9)
                {
                    break;
                }

                // print only odd values
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }

                i++; // don't forget to increment your iterator value each time!
            }

            /*
             * 
             * 2) DO-WHILE
             * 
             */
            Console.WriteLine("\ndo-while loop example:");

            string guess;

            do
            {
                Console.WriteLine("Guess a Number (777)");
                guess = Console.ReadLine();
            } while (!guess.Equals("777"));

            /*
             * 
             * 3) FOR
             * 
             */
            Console.WriteLine("\nfor loop example:");

            for (int k = 0; k < 10; k++)
            {
                if ((k % 2) > 0)
                {
                    Console.WriteLine(k);
                }
            }

            /*
             * 
             * 4) FOREACH
             * 
             */
            Console.WriteLine("\nforeach loop example:");

            string randStr = "Here are some random text";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }
        }
    }

    class StrongString
    {
        public void StringExamples()
        {
            string myString = "A bunch of random words";
            string anotherString = "More random words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(myString)); // => false
            Console.WriteLine("Is whitespace string " + String.IsNullOrWhiteSpace(myString)); // => false
            Console.WriteLine("String length: " + myString.Length); // => 23
            Console.WriteLine("Index of \'bunch\': " + myString.IndexOf("bunch")); // => 2
            Console.WriteLine("2nd word is: " + myString.Substring(2, 6)); // => "bunch"

            Console.WriteLine("Strings are equal: " + myString.Equals(anotherString)); // => false
            Console.WriteLine("Starts with \'A bunch\': " + myString.StartsWith("A bunch")); // => true
            Console.WriteLine("Ends with \'words\': " + myString.EndsWith("words")); // => true

            /*
             * 
             * Also: string.Trim() / TrimEnd() / TrimStart() - 
             * trims all whitespaces / at the end of the string / at ste start
             * 
             */

            myString = myString.Replace("words", "characters"); // => "A bunch of random characters"
            myString = myString.Remove(0, 2); // => "bunch of random words"

            string[] names = new string[3] { "Matt", "Joe", "Helen" };
            Console.WriteLine("Name List: " + String.Join(", ", names));

            /*
             * 
             * Format string
             * 
             */
            string frmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 34.891, .45, 10000);
            Console.WriteLine(frmtStr);
        }
    }

    class StrBuilder
    {
        public void Sbuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Ilia", "Maryland");
            sb.Replace("a","e");
            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());
        }
    }

    class ArraySample
    {
        public void Arr()
        {
            /*
             * 
             * Array declaration and init
             * 
             */
            int[] randNumArray; // simple array declaration w/o data

            int[] randArray = new int[5]; // array with 5 items w/o data

            int[] randArr = { 1, 2, 3, 4, 5 }; // array declaration with data

            Console.WriteLine("Array Length is: " + randArr.Length);
            Console.WriteLine("Item 0: " + randArr[0]);

            // Search index by array element
            Console.WriteLine("Where is 2 number in array? It's index is: " + Array.IndexOf(randArr, 2));

            /*
             * 
             * Iteration Array
             * 
             */
            for (int i = 0; i < randArr.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, randArr[i]);
            }

            foreach (int num in randArr)
            {
                Console.WriteLine(num);
            }

            // Array with Strings
            string[] names = { "Joe", "Pete", "Jessey" };
            string strName = string.Join(", ", names);

            Console.WriteLine("String from Array names: " + strName);

            string[] nameArray = strName.Split(',');

            foreach (string name in nameArray)
            {
                Console.WriteLine(name.Trim());
            }

            /*
             * 
             * Mult array
             * 
             */
            int[,] mltArr = new int[5, 3];
            int[,] multArray = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num in multArray)
            {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray.GetLength(0); x++)
            {
                for (int y = 0; y < multArray.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1}: {2}", x, y, multArray[x,y]);
                }
            }
        }
    }

    class ListExample
    {
        public void GetListExample()
        {
            // List is like an array but w/o size
            List<int> numList = new List<int>();

            // Each added element to list automatically resize the list
            numList.Add(5);
            numList.Add(15);
            numList.Add(1984);

            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }

            numList.Clear();

            // Initialize new list with array
            List<int> initList = new List<int>(randArray);

            // ... or maybe like that
            List<int> newArrList = new List<int>(new int[] { 5, 6, 7, 8 });

            newArrList.Insert(1, 10);
            newArrList.Remove(3);
            newArrList.RemoveAt(2);

            Console.WriteLine("------------");
            Console.WriteLine("newArrList:");

            // Attention: use `Count` instead of `Length`!
            for (int i = 0; i < newArrList.Count; i++)
            {
                Console.WriteLine(newArrList[i]);
            }

            // Find index for list element
            Console.WriteLine("Index for 8 number is: " + newArrList.IndexOf(8));

            // Is element contains in List?
            Console.WriteLine("Is element 10 contains in List? " + newArrList.Contains(10));

            Console.WriteLine("------------");
            Console.WriteLine("String List:");

            // And what about string lists?
            List<string> strList = new List<string>(new string[] { "George", "Ben" });

            // Ignore letter case when looking something and comparing like a string
            Console.WriteLine("Ben in list? " + strList.Contains("ben", StringComparer.OrdinalIgnoreCase));

            // Sort alphabetically
            strList.Sort();
        }
    }

    class ExeptionExample
    {
        public void GetExeptionExample()
        {
            // Basics of exception handling
            try
            {
                Console.WriteLine("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can\'t divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

                // We can throw another exception e.g. for other part of our application
                throw new InvalidOperationException("Operation Failed", ex);
            }

            // Default catch for all (other) exceptions
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name Yet";
            this.sound = "";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        // GO!
        public void AnimalFarm()
        {
            // create new object using constructor method
            Animal kiko = new Animal(3, 4, "Kiko", "Wrrrrraauuuu");

            Console.WriteLine("{0} says {1}", kiko.name, kiko.sound);

            // get data from static class method
            Console.WriteLine("Total number of animals: " + Animal.getNumOfAnimals());

            Console.WriteLine(kiko.toString());

            /*
             * 
             * Create Dog():Animal() object
             * 
             */
            Dog spike = new Dog();

            // just show how init constructor works
            Console.WriteLine(spike.toString());

            // now set some other real data about Spike
            spike = new Dog(20, 15, "Spike", "Woof", "Beer and crisps");

            Console.WriteLine(spike.toString());
        }

        class Dog : Animal
        {
            public string favFood { get; set; }

            public Dog(): base()
            {
                this.favFood = "No Food";
            }

            public Dog(double height, double weight, string name, string sound, string favFood): base(height, weight, name, sound)
            {
                this.favFood = favFood;
            }

            // override some Animal class methods
            // use `new` operator for overriding
            new public string toString()
            {
                return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
            }
        }
    }

    class OverloadSample
    {
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double dbl1 = 1, double dbl2 = 1)
        {
            return dbl1 + dbl2;
        }

        public void GetOverloadSample()
        {

        }
    }

    class Abstractions
    {
        // Abstract classes and interfaces
        abstract class Shape
        {
            public abstract double area();

            public void sayHi()
            {
                Console.WriteLine("Hello");
            }
        }

        public interface ShapeItem
        {
            double area();
        }

        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double num1, double num2)
            {
                length = num1;
                width = num2;
            }

            public override double area()
            {
                return length * width;
            }

            // Operator overloading example
            public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
            {
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;

                return new Rectangle(rectLength, rectWidth);
            }
        }

        class Triangle : Shape
        {
            private double theBase; // a triangle base
            private double height; // a triangle height

            public Triangle(double num1, double num2)
            {
                theBase = num1;
                height = num2;
            }

            public override double area()
            {
                return .5 * (theBase * height);
            }
        }

        public void ShowMeAbstractions()
        {
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect Area: " + rect.area());
            Console.WriteLine("Tri Area: " + tri.area());

            // Use reloaded method
            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);
            Console.WriteLine("combRect Area: " + combRect.area());
        }
    }

    class GenericExample
    {
        // We don't know about types when using generic classes
        class KeyValue<TKey, TValue>
        {
            public TKey key { get; set; }
            public TValue value { get; set; }

            public KeyValue(TKey k, TValue v)
            {
                key = k;
                value = v;
            }

            public void showData()
            {
                Console.WriteLine("{0} is {1}", this.key, this.value);
            }
        }

        public void ShowGenericExample()
        {
            // 1) params have `string` types
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            superman.showData();

            // 2) params have different types
            KeyValue<int, string> iphone = new KeyValue<int, string>(0, "");

            iphone.key = 987;
            iphone.value = "My first smartphone";

            iphone.showData();
        }
    }

    /*
     * 
     * Create enumerator type outside of some classes
     * 
     */
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    class EnumExample
    {
        public void ShowEnumExample()
        {
            Temperature micTemp = Temperature.Low;

            switch(micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
        }
    }

    /*
     * 
     * Create structures, outside of some class
     * 
     */ 
    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCustomer(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCustomer()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("ID: " + id);
        }
    }

    class StructExample
    {
        public void ShowStructExample()
        {
            Customers bob = new Customers();

            bob.createCustomer("Bob", 1960.39, 1703);
            bob.showCustomer();
        }
    }

    // delegate example
    delegate double GetSum(double num1, double num2);

    class Program
    {
        static void AddDivider()
        {
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            /* Use RandomValue class */
            //RandomValue rand = new RandomValue();
            //rand.GetRandomValue();

            //AddDivider();

            /* Use DiffTypes class */
            //DiffTypes diffTypes = new DiffTypes();
            //diffTypes.DisplayTypes();

            //AddDivider();

            /* Use MathActions class */
            //MathActions mathAct = new MathActions();
            //mathAct.ShowMeThePowerOfMath();

            //AddDivider();

            /* Loops */
            //Loops loopExmpl = new Loops();
            //loopExmpl.LoopExamples();

            //AddDivider();

            /* Strings */
            //StrongString str = new StrongString();
            //str.StringExamples();

            //AddDivider();

            /* StringBuilder */
            //StrBuilder sb = new StrBuilder();
            //sb.Sbuilder();

            //AddDivider();

            /* Arrays */
            //ArraySample arr = new ArraySample();
            //arr.Arr();

            //AddDivider();

            /* Lists */
            //ListExample lst = new ListExample();
            //lst.GetListExample();

            //AddDivider();

            /* Exceptions */
            //ExeptionExample exptSample = new ExeptionExample();
            //exptSample.GetExeptionExample();

            //AddDivider();

            /* Work with classes and class constructor */
            //Animal myPet = new Animal();
            //myPet.AnimalFarm();

            //AddDivider();

            /* Abstractions */
            //Abstractions abst = new Abstractions();
            //abst.ShowMeAbstractions();

            /* Generic classes */
            //GenericExample gnrc = new GenericExample();
            //gnrc.ShowGenericExample();

            /* Enum */
            //EnumExample enumSample = new EnumExample();
            //enumSample.ShowEnumExample();

            /* Struct */
            //StructExample structSmpl = new StructExample();
            //structSmpl.ShowStructExample();

            /* Delegate */
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));

            /* Lamdba expressions */
            // 1) Anonymous functions
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            // 2) Work with lists
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach (int num in oddNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}

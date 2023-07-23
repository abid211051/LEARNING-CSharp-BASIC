using System.Collections;

namespace Learning
{
    class Program
    {
        // global and local variable or class and method scope
        static int glob = 22;

        static void Main()
        {
            Console.WriteLine("//** DATA TYPES IN C# **//");
            /***data type***/
            //explicitly
            bool toogle = false;
            int a, e;
            a = e = 11;
            long ll = 23242342L;
            float b = 2.3f;
            double c = 3.2d;
            char d = 'a';
            string s = "abid afnan";
            Console.WriteLine(s + " " + d);
            Console.WriteLine(c + " " + e + " " + toogle);
            Console.WriteLine($"sizeof int is : {sizeof(int)} \n{a} {b} {ll}");//this $"" called string interpolation
            //implicitly
            var value = 'a';
            Console.WriteLine(value.GetType());
            // const is use if we don't want to modify existing value. throw and error
            const int con = 3;
            //con = 5; can't change value
            Console.WriteLine(con);



            Console.WriteLine($"\n//** TYPE CASTING IN C# **//");
            /*** type casting ***/
            //implicit casting(automatically by compiler)
            //char -> int -> long -> float -> double ex:
            char ch = 'a';
            int typeim = ch;
            Console.WriteLine(typeim);
            //explicit casting(manually)
            //double -> float -> long -> int -> char
            double typ1 = 3.22d;
            int typ2 = (int)typ1;
            string typ3 = "4411";
            bool typ4 = false;
            Console.WriteLine($"{typ1} {typ2}");
            Console.WriteLine(Convert.ToInt32(typ3));
            Console.WriteLine(Convert.ToString(typ4));
            Console.WriteLine(int.Parse(typ3));
            //we can use TryParse for typecasting,
            //which we will see in condional block




            Console.WriteLine("\n//** USER INPUT IN C# **//");
            /*** taking user input ***/
            Console.WriteLine("enter first input");
            string inp1 = Console.ReadLine();
            Console.WriteLine("enter second input");
            string inp2 = Console.ReadLine();
            Console.WriteLine($"type of input in c# : {inp2.GetType()}");
            int par1 = int.Parse(inp1);
            Console.WriteLine($"after parsing : {par1.GetType()} {par1}");
            double par2 = double.Parse(inp2);
            Console.WriteLine($"after parsing : {par2.GetType()} {par2}");
            Console.WriteLine(par1 + par2);



            /*** operators ***/
            //operatore in c# are same as c and c++


            Console.WriteLine("\n//** MATH CLASS IN C# **//");
            /*** Math class in c# ***/
            int Mathmax = Math.Max(4, 20);
            Console.WriteLine(Mathmax);
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(121));
            Console.WriteLine(Math.Round(9.99));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Pow(4, 2));


            Console.WriteLine("\n//** CONDITIONAL AND BRANCHING IN C# **//");
            /*** conditional and branch statement ***/
            //TryParse
            Console.WriteLine("enter input for TryParse");
            string tr = Console.ReadLine();
            int trvalue;
            bool istrvalue = int.TryParse(tr, out trvalue);
            if (istrvalue)
            {
                Console.WriteLine($"it is a valid parsing {trvalue}");
            }
            else
            {
                trvalue = 0;
                Console.WriteLine($"parsing input was not valid, we set it as {trvalue}");
            }
            // bmi
            Console.WriteLine("enter your weight in kg");
            string wei = Console.ReadLine();
            Console.WriteLine("enter your height in cm. note: 1ft = 30.48cm and 1inch = 2.54cm");
            string hei = Console.ReadLine();
            float weight;
            bool isweight = float.TryParse(wei, out weight);
            float height;
            bool isheight = float.TryParse(hei, out height);
            if (isweight && isheight)
            {
                height /= 100;
                height *= height;
                float bmi = weight / height;
                if (bmi < 18.5)
                {
                    Console.WriteLine($"underweight  {bmi}");
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    Console.WriteLine($"normal  {bmi}");

                }
                else if (bmi > 25.0 && bmi < 29.9)
                {
                    Console.WriteLine($"overweight  {bmi}");

                }
                else
                {
                    Console.WriteLine($"obesity  {bmi}");

                }
            }
            //ternary
            string stter = "pranto";
            string anster = (stter == "pranto") ? "found" : "not found";
            Console.WriteLine(anster);



            Console.WriteLine("\n\n//** LOOP IN C# **//");
            /*** loop in c# ***/
            //while loop
            int whi = 0;
            Console.WriteLine("while loop:");
            while (whi < 5)
            {
                Console.WriteLine(whi + " ");
                whi++;
            }
            // do while
            // do while always execute 1st iteration without
            // checking condition. after 1st iteration it will
            // check condition and do task until condition mismatch
            int doi = 0;
            Console.WriteLine("do while loop:");
            do
            {
                Console.WriteLine(doi);
                doi++;
            }
            while (doi < 0);
            //for loop with nested
            Console.WriteLine("for loop: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i != 0 && j != 0 && j % i == 0)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            //foreach loop
            string[] cars = { "volvo", "bmw", "ford", "mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("\n//** ARRAY IN C# **//");
            /*** Array in c# ***/
            // declared  size Array
            // in c# we have to set Array size whenever declare an Array
            // or we can declare Array by initializing it with setting size
            string[] vehicle = new string[4] { "car", "bus", "taxi", "truck" };
            // iterate on  Array
            for (int i = 0; i < vehicle.Length; i++)
            {
                Console.WriteLine(vehicle[i]);
            }
            // alternative sintax
            int[] num = { 5, 0, 4, 3, 1 };
            int[] copyarr = new int[5];

            //some Array builtin methods
            //indexof return serarched value position if find, otherwise -1
            Console.WriteLine(Array.IndexOf(num, 9));

            //copy method copy and paste one Array element to another Array
            //copy(sourceArray, sourceArrayindextostartcopy, destinationArray, destinationArrayindextostartpaste, numberofelementtocopy)
            //simply: Array.copy(num, copyarr, 5);
            Console.WriteLine("copied Array: ");
            Array.Copy(num, 2, copyarr, 2, 3);
            foreach (var item in copyarr)
            {
                Console.WriteLine(item);
            }

            //sort method sort an Array
            Console.WriteLine("before sorting: ");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            Array.Sort(num);
            Console.WriteLine("after sorting: ");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            //reverse method can reverse an Array
            Array.Reverse(vehicle);
            Console.WriteLine("reverse vehicle Array: ");
            foreach (string item in vehicle)
            {
                Console.WriteLine(item);
            }
            //multidimensional Array
            int[,] matrix = new int[3, 3]
            {
                {0, 1, 2},
                {3, 4, 5},
                {5, 6, 7},
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 10;
                        Console.WriteLine($"index{i}{j}={matrix[i, j]}");
                    }
                    else
                    {
                        Console.WriteLine($"index{i}{j}={matrix[i, j]}");

                    }
                }
            }
            string[,,] threed = new string[2, 1, 2]
            {
                {
                    {"one","two"}
                },
                {
                    {"three","four"}
                }
            };
            for (int i = 0; i < threed.GetLength(0); i++)
            {
                for (int j = 0; j < threed.GetLength(1); j++)
                {
                    for (int k = 0; k < threed.GetLength(2); k++)
                    {
                        Console.WriteLine($"index{i}{j}{k}={threed[i, j, k]}");
                    }
                }
            }
            //drawback of foreach is we can't modifiy the element through this loop
            //i mean element1 = 4 not possible
            foreach (string element1 in threed)
            {
                Console.WriteLine(element1);
            }
            //Arraylist is a dynamic type Array, which can be any size
            //and it can hold multiple types of value inside one Array
            ArrayList mylist = new ArrayList();
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add("mylistone");
            mylist.Add(4.4);
            mylist.Add('c');
            mylist.Add(10);
            mylist.Add(2.3);
            Console.WriteLine(mylist.Count);
            int sum = 0;
            foreach (object item in mylist)
            {
                if (item is int)
                {
                    sum += (int)item;
                }
                else
                {
                    continue;
                }
            }
            //list
            List<string> list = new List<string>();
            list.Add("abid");
            list.Add("afnan");
            list.Add("pranto");
            list.ForEach (x => { Console.WriteLine(x); }) ;
            Console.WriteLine(sum);
            mylist.Remove('c');
            mylist.RemoveRange(3, 3);
            Console.WriteLine(mylist.Count);
            //jaggedArray
            //jagged Array is an Array of Arrays.it's means it store
            //multiple Array in a single Array
            int[][] jagged = new int[2][]
            {
                new int[3] { 1, 4, 6},
                new int[3] { 3, 4, 7}
            };
            Console.WriteLine($"jagged Array value: {jagged[0][0]}, {jagged[1][0]}");



            Console.WriteLine("\n//** FUNCTION CALLING IN C# **//");
            /*** function or methods ***/
            //void function
            local("parameter one");

            //return type function
            double ans = div(29, 20);
            Console.WriteLine(ans);



            Console.WriteLine("\n//** EXCEPTION HANDELING IN C# **//");
            /*** exception handeling ***/
            // there can be many excepion. some are:
            // 1. formate exception
            // 2. overflow exception for init, float etc
            // 3. divide overflow exception, when divide by 0
            // finally will call anyways. it will execute even after try catch
            // can use finally to close infite task after error, like : file
            try
            {
                Console.WriteLine("enter first input");
                string first = Console.ReadLine();
                Console.WriteLine("enter second input");
                string second = Console.ReadLine();
                int ans1 = int.Parse(first);
                int ans2 = int.Parse(second);
                Console.WriteLine(ans1 / ans2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("there is a error" + ex);
            }
            finally
            {
                Console.WriteLine("program is terminated");
            }

        }
        public static void local(string param)
        {
            //accessing global variable which is outside methods
            Console.WriteLine(glob);
            //prnting parameter from main method
            Console.WriteLine(param);
            //swapping two number
            int a = 3;
            int b = 2;
            int t;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("after swapping: " + "a = " + a + " " + "b = " + b);
        }
        public static double div(double a, double b)
        {
            return a / b;
        }
    }
}
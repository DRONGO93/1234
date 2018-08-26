using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        //2
        //static PropertyInfo GetPropertyInfo(object obj, string str)
        //{
        //    return obj.GetType().GetProperty(str);
        //}

        //Параметры для Main.
        //static, (string[] args) - чтобы не потерять.

        //5
        //public static IEnumerable<int> GetSmallNumbers()
        //{
        //    //yield return 1;
        //    yield return 2;
        //    yield return 4;
        //    throw new Exception();
        //}

        //11
        //static void Fobos()
        //{
        //    var x = "AB";
        //    var y = new StringBuilder().Append('A').Append('B').ToString();
        //    var z = string.Intern(y);
        //    Console.WriteLine(x == y);
        //    Console.WriteLine(x == z);
        //    Console.WriteLine((object)x == (object)y);
        //    Console.WriteLine((object)x == (object)z);
        //    Console.ReadKey();
        //}

        //12
        //[ThreadStatic]
        //static readonly int Foo = 42;

        //13
        //private readonly ReaderWriterLockSlim lockSlim;
        //public Program(ReaderWriterLockSlim lockSlim)
        //{
        //    this.lockSlim = lockSlim;
        //    lockSlim.EnterWriteLock();
        //}
        //~Program()
        //{
        //    Console.WriteLine("~Foo: start");
        //    try
        //    {
        //        if (lockSlim != null)
        //            lockSlim.ExitReadLock();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exeption: " + e.GetType().Name);
        //    }
        //    Console.WriteLine("~Foo: finish");
        //}

        static void Main(string[] args)
        {

            #region
            //1
            //Type type = typeof(int);
            //Console.WriteLine(type);
            //int i = 0;
            //Type type2 = i.GetType();
            //Console.WriteLine(type2);
            //Console.ReadKey();

            //2
            //DateTime dateTime = new DateTime();
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
            //Console.ReadKey();

            //3
            //Uber();
            //int Inc(int x)
            //{
            //    Console.WriteLine("Inc: " + x);
            //    return x + 1;
            //}
            //void Uber ()
            //{
            //    var numbers = Enumerable.Range(0, 10);
            //    var query =
            //        (
            //        from number in numbers
            //        let number2 = Inc(number)
            //        where number2 % 2 == 0
            //        select number2
            //        ).Take(2);
            //    foreach (var number in query)
            //        Console.WriteLine("Number: " + number);
            //    Console.ReadKey();
            //}

            //4
            //var action = new List<Action>();
            //for (int i = 0; i < 3; i++)
            //    action.Add(() => Console.WriteLine(i));
            //foreach (var actionvaag in action)
            //    actionvaag();
            //Console.ReadKey();

            //5
            //Macaca();
            //void Macaca()
            //{
            //    var numbers = GetSmallNumbers();
            //    var evenNumbers = numbers.Select(n => n * 3);
            //    Console.WriteLine(evenNumbers.FirstOrDefault());
            //    Console.ReadKey();
            //}

            //6
            //Kara();
            //void Kara()
            //{
            //    var list = new List<string> { "Foo", "Bar", "Baz" };
            //    var startLetter = "F";
            //    var query = list.Where(c => c.StartsWith(startLetter));
            //    startLetter = "B";
            //    query = query.Where(c => c.StartsWith(startLetter));
            //    Console.WriteLine(query.Count());
            //    Console.ReadKey();
            //}

            //7
            //Manj();
            //void Manj()
            //{
            //    int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //    var numQuery =
            //        from num in numbers
            //        where (num % 2) == 0
            //        select num;
            //    foreach (int num in numQuery)
            //    {
            //        Console.Write("{0,1} ", num);
            //    }
            //}

            //8
            //Console.WriteLine('A' + 0);
            //Console.WriteLine('a' + 0);
            //Console.ReadKey();

            //9
            //try
            //{
            //    Console.WriteLine(((string)null + null + null) == null);
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("e.GetType()");
            //}
            //Console.ReadKey();

            //10
            //string a = "Makssimov";
            //string b = "Maksdfssimov";
            //Console.WriteLine(string.Compare(a.ToUpper(), b.ToUpper()));
            //Console.WriteLine(string.Compare(a, b, StringComparison.OrdinalIgnoreCase));
            //Console.ReadKey();

            //11
            //Fobos();

            //12
            //MMM();
            //void MMM()
            //{
            //    var thread = new Thread(() => Console.WriteLine(Foo));
            //    thread.Start();
            //    thread.Join();
            //}
            //Console.ReadKey();

            //13
            //var foo = new Program(new ReaderWriterLockSlim());
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            #endregion

        }
    }
}
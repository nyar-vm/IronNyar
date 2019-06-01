using System;
using System.Dynamic;
using System.Linq.Expressions;
using IronNyar;
using IronNyar.Operator;


namespace IronNyar.Runtime
{
    class Program
    {


        public static class SF
        {


            public static void somename()
            {
                Expression<Func<int>> add = () => 1 + 2;
                var func = add.Compile(); // Create Delegate
                var answer = func(); // Invoke Delegate
                Console.WriteLine(answer);
            }

            public static void somename2()
            {
                var lhs1 = new Object.Number.Integer.Integer32("5");
                var rhs1 = new Object.Number.Integer.Integer32("20");
                var ans1 = Middle.Plus(lhs1, rhs1);
                Console.WriteLine("{0}", ans1.__type__);
                var lhs2 = new Object.Number.Integer.Integer32("5");
                var rhs2 = new Object.Number.Integer.Integer64("20");
                var ans2 = Middle.Plus(lhs2, rhs2);
                Console.WriteLine("{0}", ans2.__type__);
            }

            public static void somename3()
            {
                var xParameter = Expression.Parameter(typeof(double), "x");
                var yParameter = Expression.Parameter(typeof(double), "y");
                var xSquared = Expression.Multiply(xParameter, xParameter);
                var ySquared = Expression.Multiply(yParameter, yParameter);
                var sum = Expression.Add(xSquared, ySquared);
                var sqrtMethod = typeof(Math).GetMethod("Sqrt", new[] { typeof(double) });
                var distance = Expression.Call(sqrtMethod, sum);
                var distanceLambda = Expression.Lambda(
                    distance,
                    xParameter,
                    yParameter
                );

            }



        }

        static void Main(string[] args)
        {



            SF.somename2();

            /*
            var logger = new Function.REPL();



            */










        }
    }
}

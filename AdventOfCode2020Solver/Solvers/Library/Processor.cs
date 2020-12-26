using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AdventOfCode.Library
{
    /// <summary>
    /// Extension methods that will apply to various string related data
    /// returned from <see cref="TextUtility"/>
    /// </summary>
    public static class Processor
    {
        public static void Process(this string s, bool flag, int index, Func<string, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }

        public static void Process(this List<string> s, bool flag, int index, Func<List<string>, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }

        public static void Process(this List<List<string>> s, bool flag, int index, Func<List<List<string>>, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }

        public static void Process(this string s, bool flag, int index, object extra, Func<string, object, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s, extra);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }

        public static void Process(this List<string> s, bool flag, int index, object extra, Func<List<string>, object, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s, extra);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }

        public static void Process(this List<List<string>> s, bool flag, int index, object extra, Func<List<List<string>>, object, string> func)
        {
            if (!flag)
            {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();
            string answer = func(s, extra);
            watch.Stop();

            WriteOutput(index, answer, watch.ElapsedMilliseconds); 
        }
        private static void WriteOutput(int index, string answer, long milliseconds)
        {
            Console.WriteLine($"PART {index} ANSWER:\t{answer}\n{milliseconds} ms\n");
        }
    }
}

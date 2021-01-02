using CppWrapper;
using System;

namespace TestApp
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var record = new RecordA(5, 1.1F, 2.12211);
            ExternModules.UseStruct(30, record, out int no, out var so);

            Console.WriteLine($"Int = {no}");
            Console.WriteLine("Struct = {");
            Console.WriteLine($"    int: {so.intValue},");
            Console.WriteLine($"    float: {so.floatValue},");
            Console.WriteLine($"    double: {so.doubleValue}");
            Console.WriteLine("}");
        }
    }
}
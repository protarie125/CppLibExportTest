using CppWrapper;
using System;

namespace TestApp
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var record = new RecordA(5, 1.1F, 2.12211);
            // in으로 전달하기 위한 임시객체가 생성되지만,
            // 구조체를 직관적으로 사용하기 위해 in 한정자를 생략할 수 있다.
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
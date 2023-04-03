using System.Reflection;
using System;
using System.IO;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            var dz8 = Assembly.Load(File.ReadAllBytes("dz8.dll"));
            Type dz8type = dz8.GetType();
            
            var dz8types = dz8.GetTypes();
            Console.WriteLine(string.Join(' ', dz8types.Select(x => x.Name)));
            
            Console.WriteLine($"Name: {dz8type.Name}");
            Console.WriteLine($"Full Name: {dz8type.FullName}");
            Console.WriteLine($"Namespace: {dz8type.Namespace}");
            Console.WriteLine($"Is struct: {dz8type.IsValueType}");
            Console.WriteLine($"Is class: {dz8type.IsClass}");

            var instance = Activator.CreateInstance(dz8type);
            Console.WriteLine($"Email: {dz8type.GetProperty("Email").GetValue(instance, null)}");
        }
    }
}

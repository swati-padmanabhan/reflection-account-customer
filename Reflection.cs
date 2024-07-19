using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorAccountCustomer.models
{
    internal class Reflection
    {
        public void ShowDetails(Type type)
        {

            PropertyInfo[] properties = type.GetProperties();
            ConstructorInfo[] constructors = type.GetConstructors();
            MethodInfo[] methods = type.GetMethods();

            Console.WriteLine($"Type: {type.Name}\n" +
                $"Number of properties: {properties.Length}\n" +
                   $"Number of constructors: {constructors.Length}\n" +
                   $"Number of methods: {methods.Length}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class ReflectionTest
    {
        Type type = typeof(CustomerInfo);

        Console.WriteLine("Full Name : {0}", type.FullName);

        Console.WriteLine("Class Name : {0}", type.Name);

        MethodInfo[] methods = type.GetMethod();

        foreach (MethodInfo method in methods)
            {
            Console.WriteLine(methd.Returntype.Name + " " + method.Name);
            }

    Console.WriteLine("properties");
             
         PropertyInfo[] properties = type.GetProperties();

        foreach(PropertyInfo property in properties)
            {
            Console.WriteLine(property.PropertyType.Name + " " + property.Name)
            }
Console.WriteLine("Contructors in customer class");

            ConstructorInfo[] constructors = Type.GetConstructors();
     foreach( in s)
            {
            Console.WriteLine(constructor.ToString());
        }

    }
}    
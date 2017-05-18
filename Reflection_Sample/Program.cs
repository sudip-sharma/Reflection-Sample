using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Sample
{
    public class Program
    {
        public static void Main()
        {
            Type t = Type.GetType("Reflection_Sample.Customer");
            PropertyInfo[] properties = t.GetProperties();

            Console.WriteLine();
            Console.WriteLine("The properties of the Customer class are :- ");            

            foreach (PropertyInfo obj in properties)
            {
                Console.WriteLine(obj.Name + " " + obj.PropertyType);                
            }

            Console.WriteLine();
            Console.WriteLine("The methods of the Customer class are :- ");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo obj in methods)
            {
                Console.WriteLine(obj.Name + " " + obj.ReturnType);                
            }

            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int MyProperty { get; set; }
        public string MyStrProperty { get; set; }

        public void GetCustomerName()
        { }

        public void SaveCustomerName()
        { }
    }
}

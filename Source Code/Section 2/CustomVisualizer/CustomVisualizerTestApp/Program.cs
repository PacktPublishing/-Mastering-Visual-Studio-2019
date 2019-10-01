using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomVisualizer;

namespace CustomVisualizerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value to use the new form: ");
            var input = Console.ReadLine();
            var list = new List<CustomTestObject>();
            var newObject = new CustomTestObject();
            newObject.Message = input;
            newObject.Title = "Testing";
            var secondObject = new CustomTestObject() { Message = newObject.Message, Title = "second", Timeout = 14 };
            list.Add(newObject);
            list.Add(secondObject);
            MyCollectionVisualizer.TestShowVisualizer(list);
            Console.ReadLine();
        }
    }
}

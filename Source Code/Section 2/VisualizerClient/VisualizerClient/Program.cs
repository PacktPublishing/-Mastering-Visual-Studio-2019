using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value to use the new form: ");
            var input = Console.ReadLine();
            var newObject = new TestObject();
            var list = new TestList();
            newObject.Message = input;
            newObject.Title = "Testing";
            var secondObject = new TestObject() { Message = newObject.Message, Title = "second", Timeout = 14 };
            list.Add(newObject);
            list.Add(secondObject);
            Console.ReadLine();
        }
    }
}

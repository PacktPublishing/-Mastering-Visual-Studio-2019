using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomVisualizer
{
    [DebuggerVisualizer(typeof(MyObjectVisualizer))]
    [Serializable()]
    public class CustomTestObject
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public int Timeout { get; set; }
        public string[] Options { get; set; }

        public CustomTestObject()
        {
            Options = new string[] { "One", "Two" };

        }
    }
}

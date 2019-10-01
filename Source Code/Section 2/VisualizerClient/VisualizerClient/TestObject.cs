using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizerClient
{
    [DebuggerVisualizer(typeof(CustomVisualizer.MyObjectVisualizer), Target = typeof(TestObject))]
    [Serializable()]
    public class TestObject
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public int Timeout { get; set; }
        public string[] Options { get; set; }

        public TestObject()
        {
            Options = new string[] { "One", "Two" };
        }
    }

    [DebuggerVisualizer(typeof(CustomVisualizer.MyCollectionVisualizer), Target = typeof(List<TestList>))]
    [Serializable()]
    public class TestList: List<TestObject>
    {

    }
}

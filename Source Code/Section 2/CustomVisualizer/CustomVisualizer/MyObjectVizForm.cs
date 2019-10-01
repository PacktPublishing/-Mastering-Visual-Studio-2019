using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomVisualizer
{
    public partial class MyObjectVizForm : Form
    {
        public MyObjectVizForm()
        {
            InitializeComponent();
        }

        public MyObjectVizForm(object target):this()
        {
            MyObjectPropGrid.SelectedObject = target;
        }
    }
}

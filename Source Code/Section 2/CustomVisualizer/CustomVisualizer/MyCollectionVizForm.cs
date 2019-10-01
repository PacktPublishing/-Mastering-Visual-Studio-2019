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
    public partial class MyCollectionVizForm : Form
    {
        public MyCollectionVizForm()
        {
            InitializeComponent();
        }

        public MyCollectionVizForm(object source) :this()
        {
            MyCollectionDataGrid.DataSource = source;
        }
    }
}

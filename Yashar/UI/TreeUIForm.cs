using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yashar.UI
{
    public partial class TreeUIForm : Form
    {
        public TreeUIForm(TreeView tv)
        {
            this.treeView1 = tv;
            InitializeComponent();          
        }
    }
}

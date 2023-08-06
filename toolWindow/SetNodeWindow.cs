using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace opencvNode.toolWindow
{
    public partial class SetNodeWindow :UIEditForm
    {
        public string name;
        public SetNodeWindow()
        {
            InitializeComponent();
        }

        private void SetNodeWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            name = uiTextBox1.Text;
        }
    }
}

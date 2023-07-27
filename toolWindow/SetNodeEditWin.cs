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
    
    public partial class SetNodeEditWin :UIEditForm
    {
        public string editname;
        public SetNodeEditWin()
        {
            InitializeComponent();
        }

        private void SetNodeEditWin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            editname = uiTextBox1.Text;
        }
    }
}

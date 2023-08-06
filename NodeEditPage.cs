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

namespace opencvNode
{
    public partial class NodeEditPage : UIPage
    {
        public NodeEditPage()
        {
            InitializeComponent();
        }

        private void NodeEditPage_Load(object sender, EventArgs e)
        {

        }

        private void stNodeEditor1_Click(object sender, EventArgs e)
        {

        }

        private void ShowMenu(object sender, MouseEventArgs e)
        {

           
            //设置弹出菜单
            if (e.Button == MouseButtons.Right && stNodeEditor1.ActiveNode!=null)
            {
                Point p = new Point();
                p.X = share.ShareClass.formX+e.X+177;
               
                p.Y = share.ShareClass.formY+e.Y+140;
                contextMenuStrip1.Show(p);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除当前节点
            stNodeEditor1.Nodes.Remove(stNodeEditor1.ActiveNode);
            
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolWindow.SetNodeWindow setNodeWindow = new toolWindow.SetNodeWindow();
            setNodeWindow.ShowDialog();
            if (setNodeWindow.IsOK)
            {
                stNodeEditor1.ActiveNode.Title = setNodeWindow.name;
            }
        }
    }
}

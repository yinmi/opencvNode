using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace opencvNode
{
    public partial class Form3 : UIPage
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //增加流程编辑窗口
           if(tabControl1.TabPages.Count<=13)
            {
                NodeEditPage nodeEditPage = new NodeEditPage();
                TabPage newPage = new TabPage();
                newPage.Text = "newpage";
                newPage.Controls.Add(nodeEditPage);
                tabControl1.TabPages.Add(newPage);

                nodeEditPage.Show();
            }
     
        }

        private void stNodeEditor1_Click(object sender, EventArgs e)
        {

        }

        private void addTapage(object sender, DrawItemEventArgs e)
        {
            //设置笔刷
            SolidBrush blue = new SolidBrush(Color.FromArgb(0x50,0xA0,0xff));
            SolidBrush white = new SolidBrush(Color.White);      
             //设置背景
             
             //e.Graphics.FillRectangle(blue, rectangleRed);
          
             //设置标签文字居中对齐
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
             //设置标签文字
             for (int i = 0; i <tabControl1.TabPages.Count; i++)
             {
                Rectangle rec = tabControl1.GetTabRect(i);
                //设置背景
                e.Graphics.FillRectangle(blue, rec);
                //设置文字字体和文字大小
                e.Graphics.DrawString(tabControl1.TabPages[i].Text, new Font("宋体", 10),white , rec, stringFormat);
               }
        }

        private void deleteTabpage_Click(object sender, EventArgs e)
        {
            //移除当前选中流程页
            if(tabControl1.TabPages.Count>1)
            {
                
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            }
        }
    }
}

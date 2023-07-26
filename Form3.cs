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

        private void AddTabpage(object sender, DrawItemEventArgs e)
        {
            //定义颜色
            SolidBrush blue = new SolidBrush(Color.FromArgb(0x50,0xA0,0xff));
            SolidBrush white = new SolidBrush(Color.White);
           // Rectangle tabArea = tabControl1.GetTabRect(e.Index);
            //背景颜色
           // e.Graphics.FillRectangle(blue, tabArea);
            //字体居中
            StringFormat stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center;  
            stringFormat.LineAlignment = StringAlignment.Center;


            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                Rectangle rec = tabControl1.GetTabRect(i);
                //设置背景颜色
                e.Graphics.FillRectangle(blue, rec);
                //设置标签文字字体和文字大小
                e.Graphics.DrawString(tabControl1.TabPages[i].Text,
                    new Font("宋体", 12), white, rec, stringFormat);
            }




        }
    }
}

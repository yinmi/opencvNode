using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST.Library.UI.NodeEditor;
using System.Windows.Forms;
using System.Drawing;

namespace opencvNode.STnode
{
    [STNode("图像操作", "Author", "Mail", "Link", "Description")]
    public class Node_GetPicture: Node_Base
    {

        


        public Node_GetPicture()
        {
            this.Title = "获取图片";
            this.tool = new tool.GetPicture();
        }

        protected override void OnCreate()
        {



            base.OnCreate();

            int nindex = this.InputOptions.Add(new STNodeOption("IN", typeof(string), false));

            this.OutputOptions.Add("OUT", typeof(string), false);

            
         }
       protected override void OnMouseClick(MouseEventArgs e)
        {
           

           


        }

     
        
}
}

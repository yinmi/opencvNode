﻿using System;
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
    public class Node_GetPicture:STNode
    {


        public Node_GetPicture()
        {
            this.Title = "获取图片";
        }

        protected override void OnCreate()
        {



            base.OnCreate();

            int nindex = this.InputOptions.Add(new STNodeOption("IN", typeof(string), false));

            this.OutputOptions.Add("OUT", typeof(string), false);

            
         }
       protected override void OnMouseClick(MouseEventArgs e)
        {
           

            /*
            if(e.Button==MouseButtons.Right)
            {
                Point p = new Point();
                p.X = this.Location.X + e.X;
                p.y = this.Location.Y + e.Y;
                
            }
           */


        }

     
        
}
}

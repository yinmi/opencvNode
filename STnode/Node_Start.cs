using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST.Library.UI.NodeEditor;

namespace opencvNode.STnode
{
    [STNode("流程控制", "Author", "Mail", "Link", "Description")]
    public class Node_Start: Node_Base
    {
        public tool.BaseTool startTool = new tool.BaseTool();
        public Node_Start()
        {
            this.Title = "开始";
            startTool.isFrist = true;
        }

        protected override void OnCreate()
        {



            base.OnCreate();
            this.OutputOptions.Add("OUT", typeof(string), false);


        }
     

    }
}

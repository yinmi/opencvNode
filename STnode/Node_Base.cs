using ST.Library.UI.NodeEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

namespace opencvNode.STnode
{
    public  class Node_Base: STNode
    {

       public  Node_Base()
        {

        }
        

        public void ChangeTitle(string title)
        {
            Title = title;
        }
        
       
        
    }
}

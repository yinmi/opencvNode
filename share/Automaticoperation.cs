using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST.Library.UI.NodeEditor;

namespace opencvNode.share
{
    /// <summary>
    /// 运行转态枚举
    /// </summary>
    public  enum RunningState 
    {

        //查找
      lookUp,
      //执行
      carryOut,
      //结果
      result,
      //停止，
      stop
    }
    delegate bool CarryOut(object arg);
    public  class Automaticoperation
    {
        
        public void Runing ()
        {
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace opencvNode.tool
{
    [Serializable]
    public  class BaseTool
    {
        [NonSerialized]
        private Mat _image;
        private Rect _roi;
        [NonSerialized]
        private Mat _symbolImage;
        private int _imageX;
        private int _imageY;
        private double _realX;
        private double _realY;
        private double _score;
        private string _result;
        private long _consumeTime;
        private bool _isFrist;
        private bool _isOK;
        
        //原始图片
        public Mat image
        {
            set { _image = value; }
            get { return _image; }

        }

        //搜索区域
        public Rect roi
        {
            set { _roi = value; }
            get { return _roi; }
        }

        //缩略图
        public Mat symbolImage
        {
            set { _symbolImage = value; }
            get { return _symbolImage; }
        }

        //结果图像x坐标
        public int imageX
        {
            set { _imageX = value; }
            get { return _imageX; }
        }

        //结果图像Y坐标
        public int imageY
        { set { _imageY = value; }
          get { return _imageY; }
        }

        //结果X坐标
        public double realX
        {
            set { _realX = value; }
            get { return _realX; }
        }
        //结果Y坐标
        public double realY
        { set { _realY = value; }
          get { return _realY; }
        }

        //分数
        public double score
        {
            set { _score = value; }
            get { return _score; }
        }
        //结果
        public string result
        {
            set { _result = value; }
            get { return _result; }
        }
        //运行时间
        public long consumeTime
        {
            set { _consumeTime = value; }
            get { return _consumeTime;  }
        }
        //是否是第一个节点
       public bool isFrist
        {
            set { _isFrist = value; }
            get { return _isFrist; }
        }
        
        //结果是否OK
       public bool isOK
        {
            set { _isOK = value; }
            get { return _isOK;  }
        }

      /// <summary>
      /// STN 节点ID
      /// </summary>
        public Guid STN_guid { set; get; }
        /// <summary>
        /// 工具ID
        /// </summary>
        public Guid Tool_guid { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencvNode.share
{
   public  class Log4Helper
    {
        private static Log4Helper _Log;

        public static log4net.ILog Loginfo = log4net.LogManager.GetLogger("LogInfo");
        public static log4net.ILog Logerror = log4net.LogManager.GetLogger("LogError");


        public static Log4Helper Log
        {
             private  set { }

             get {

                if (_Log == null)
                {
                    _Log = new Log4Helper();
                    return _Log;
                }
                else
                    return _Log;
            }
        }

      

        public Log4Helper()
        {
            var file = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "logconf.xml");
            log4net.Config.XmlConfigurator.Configure(file);

        }

        /// <summary>
        /// 写入信息
        /// </summary>
        /// <param name="info">信息</param>
        public void WriteInfo(string info)
        {
            if (Loginfo.IsInfoEnabled)
            {
                Loginfo.Info(info);
            }
        }

        /// <summary>
        /// 写入错误信息
        /// </summary>
        /// <param name="info"></param>
        public void WriteError(string info)
        {
            if (Logerror.IsInfoEnabled)
            {
                Logerror.Info(info);
            }
        }

        /// <summary>
        /// 写入信息
        /// </summary>
        /// <param name="message"></param>
        public void Info(string message)
        {
            if(Loginfo.IsInfoEnabled)
            {
                Loginfo.Info(message);
            }
        }

        /// <summary>
        /// 写入错误信息
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            if (Logerror.IsInfoEnabled)
            {
                Logerror.Info(message);
            }
        }
        /// <summary>
        /// 写入错误信息
        /// </summary>
        /// <param name="ex"></param>

        public void Error(Exception ex)
        {
            if (Logerror.IsInfoEnabled) {
                var sb = new StringBuilder();
                sb.AppendFormat("\r\n 异常信息:{0}", ex.Message);
                sb.AppendFormat("\r\n 异常来源:{0}", ex.Source);
                sb.AppendFormat("\r\n 异常堆栈:{0}", ex.StackTrace);
                Logerror.Info(sb.ToString());
            }
        }

        /// <summary>
        /// 写入错误信息
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="ex">异常</param>
        public void Error(string msg, Exception ex)
        {
            if (Logerror.IsInfoEnabled)
            {
                Logerror.Info(msg, ex);
            }
        }

    }
}



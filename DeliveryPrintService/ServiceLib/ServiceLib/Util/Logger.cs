using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Core;
using log4net.Config;
using log4net.Repository;

namespace ServiceLib.Util
{
    public static class Logger
    {
        private static readonly int MAX_LENGTH = 7000;
        
        #region 日志类初始化

        private static ILog logger = null;
        private static Type thisType = null;

        static Logger()
        {
            XmlConfigurator.Configure();
            thisType = typeof(Logger);
            logger = log4net.LogManager.GetLogger(thisType);
            GlobalContext.Properties["ServerIp"] = WebTools.MyServerIP;
        }

        #endregion

        #region 访问日志

        public static void Access(string MethodName, bool IsSuccess, string req, string resp)
        {
            Access(MethodName, IsSuccess, req, resp, "", "");
        }

        public static void AccessMsg(string MethodName, bool IsSuccess, string MessageCategory, string Message)
        {
            Access(MethodName, IsSuccess, "", "", MessageCategory, Message);
        }

        static void Access(string MethodName, bool IsSuccess, string req, string resp, string MessageCategory, string Message)
        {
            ThreadContext.Properties["ClientIp"] = WebTools.GetClientIP();
            ThreadContext.Properties["MethodName"] = MethodName;
            ThreadContext.Properties["RequestXml"] = req;
            ThreadContext.Properties["ResponseXml"] = resp;
            ThreadContext.Properties["IsSuccess"] = IsSuccess;
            ThreadContext.Properties["MessageCategory"] = MessageCategory;
            if (Message.Length >= MAX_LENGTH) Message = Message.Substring(0, MAX_LENGTH - 1);
            logger.Logger.Log(thisType, Level.Trace, Message, null);
        }

        #endregion

        #region 错误日志

        public static void Error(string MethodName, Exception ex)
        {
            Error(MethodName, ex.Message, ex);
        }

        public static void Error(string MethodName, string Message, Exception ex)
        {
            Error(MethodName, Message, ex.GetType().Name, ExceptionFormatter.FormatException(ex));
        }

        public static void Error(string MethodName, string Message)
        {
            Error(MethodName, Message, "", "");
        }

        public static void Error(string MethodName, string Message, string ExName, string Detail)
        {
            ThreadContext.Properties["ClientIp"] = WebTools.GetClientIP();
            ThreadContext.Properties["ExName"] = ExName.Trim();
            if (Detail.Length >= MAX_LENGTH) Detail = Detail.Substring(0, MAX_LENGTH - 1);
            ThreadContext.Properties["Detail"] = Detail.Trim();
            if (!string.IsNullOrEmpty(MethodName))
                ThreadContext.Properties["MethodName"] = MethodName;
            else
                ThreadContext.Properties["MethodName"] = RefectingTools.GetInterfaceName();
            if (Message.Length >= MAX_LENGTH) Message = Message.Substring(0, MAX_LENGTH - 1);
            logger.Logger.Log(thisType, Level.Error, Message, null);
        }

        #endregion

        #region 性能日志

        public static void Performance(string Category, string Message, long Clock)
        {
            ThreadContext.Properties["ClientIp"] = WebTools.GetClientIP();
            ThreadContext.Properties["MessageCategory"] = Category;
            ThreadContext.Properties["Clock"] = Clock;
            if (Message.Length >= MAX_LENGTH) Message = Message.Substring(0, MAX_LENGTH - 1);
            logger.Logger.Log(thisType, Level.Verbose, Message, null);
        }

        #endregion

        #region 业务日志

        public static void Info(string Category, string Message)
        {
            ThreadContext.Properties["ClientIp"] = WebTools.GetClientIP();
            ThreadContext.Properties["MessageCategory"] = Category;
            if (Message.Length >= MAX_LENGTH) Message = Message.Substring(0, MAX_LENGTH - 1);
            logger.Logger.Log(thisType, Level.Info, Message, null);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using System.IO;

namespace ServiceLib.Util
{
    public class WebTools
    {
        static WebTools()
        {
            ServerIp = (Dns.GetHostAddresses(Dns.GetHostName())[0]).ToString();
        }

        #region 获取客户端的地址

        public static string GetClientIP()
        {
            string result = string.Empty;
            try
            {
                if (HttpContext.Current != null)
                {
                    result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (string.IsNullOrEmpty(result))
                        result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                    if (string.IsNullOrEmpty(result))
                        result = HttpContext.Current.Request.UserHostAddress;
                }
            }
            catch
            {
                result = "-1.-1.-1.-1";
            }

            return result;
        }

        #endregion

        #region 获取当前服务器的服务器名称

        private static string ServerIp = string.Empty;
        public static string MyServerIP
        {
            get{return ServerIp;}
        }

        #endregion
    }
}

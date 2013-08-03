using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace ServiceLib.Util
{
    public static class StringTools
    {
        #region 得到指定名称和值的赋值字符串

        public static string GetNameValue(string Name, object Value)
        {
            if (Value != null)
                return string.Format("<{0}>{1}</{0}>", Name, System.Web.HttpUtility.HtmlEncode(Value.ToString()));
            else
                return string.Format("<{0}/>", Name);
        }

        #endregion

        #region base64编码
        
        public static string EncodingForString(string sourceString)
        {
            return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(sourceString));
        }
        
        #endregion

        #region base64解码
        
        public static string DecodingForString(string base64String)
        {
            return System.Text.Encoding.Default.GetString(Convert.FromBase64String(base64String));
        }

        #endregion


        #region "通过MD5编码的字符串"
        /// <summary>
        ///通过MD5编码的字符串
        /// </summary>
        /// <param name="input">The string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string MD5String(string input)
        {
            // 生成一个 MD5CryptoServiceProvider 实例.
            MD5 md5Hasher = MD5.Create();
            //把输入字符串转换一个字节数组和计算散列
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            //遍历所有data的字符并且是把每个字符格式为16进制的字符串
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // 返回一个16进制的字符串
            return sBuilder.ToString();
        }
        #endregion



        #region MD5加密

        public static string MD5Encode(string Raw)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(Raw);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToUpper();
        }

        #endregion 

    }
}

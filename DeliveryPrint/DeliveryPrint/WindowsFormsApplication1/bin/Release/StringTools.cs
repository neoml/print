using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    public class StringTools
    {
        #region base64编码

        public static string EncodingForString(string sourceString)
        {
            return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(sourceString));
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLib.Util
{
    public class ExceptionFormatter
    {
        public static string FormatException(Exception e)
        {
            StringBuilder sbXml = new StringBuilder();

            sbXml.Append(StringTools.GetNameValue("ExName", e.GetType().Name));
            sbXml.Append(StringTools.GetNameValue("MSG", e.Message));
            sbXml.AppendLine(StringTools.GetNameValue("StackTrace", System.Web.HttpUtility.HtmlEncode(e.StackTrace)));
            sbXml.AppendLine(StringTools.GetNameValue("Source", System.Web.HttpUtility.HtmlEncode(e.Source)));
            sbXml.AppendLine(StringTools.GetNameValue("TargetSite", e.TargetSite));

            if (e.InnerException != null)
            {
                sbXml.Append("<InnerException>");
                sbXml.Append(FormatException(e.InnerException));
                sbXml.Append("</InnerException>");
            }

            if (e is Exceptionbase)
            {
                (e as Exceptionbase).ToXmlElements(sbXml);
            }

            return sbXml.ToString();
        }
    }
}

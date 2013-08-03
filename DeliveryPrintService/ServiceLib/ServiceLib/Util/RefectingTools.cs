using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace ServiceLib.Util
{
    static class RefectingTools
    {
        public static string GetInterfaceName()
        {
            string s = "";
            try
            {
                StackTrace st = new StackTrace();
                #region 获取Web方法名称
                if (st.FrameCount > 0)
                {
                    for (int i = 0; i < st.FrameCount; i++)
                    {
                        StackFrame sf = st.GetFrame(i);
                        if (sf != null)
                        {
                            MethodBase mi = sf.GetMethod();
                            if (Attribute.IsDefined(mi, typeof(System.Web.Services.WebMethodAttribute)))
                            {
                                s = string.Format("{0}.{1}", mi.DeclaringType.FullName, mi.Name);
                                break;
                            }
                        }
                    }
                }

                #endregion

                #region 若未获取到Web方法名称, 则获取顶级方法名称

                if (string.IsNullOrEmpty(s))
                {
                    if (st.FrameCount > 0)
                    {
                        StackFrame sf = st.GetFrame(0);
                        if (sf != null)
                        {
                            MethodBase mi = sf.GetMethod();
                            if (mi != null)
                                s = string.Format("{0}.{1}", mi.DeclaringType.FullName, mi.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                s = ex.Message;
            }
                #endregion
            return s;
        }
    }
}

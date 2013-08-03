using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLib.Util
{
    public abstract class Exceptionbase : Exception
    {
        public Exceptionbase()
        {
        }

        public Exceptionbase(string msg): base(msg)
        {
        }

        public Exceptionbase(string msg, Exception ex): base(msg, ex)
        {
        }

        public virtual void ToXmlElements(StringBuilder sbXml)
        {
        }
    }
}

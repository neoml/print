using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace ServiceLib.Entity
{
    [Serializable]
    public class InvoiceInfo
    {
        public string cBarCode { get; set; }

        public List<string> cPosCode { get; set; }

        public float iQuantity { get; set; }

        public string cFree1 { get; set; }

        public string cFree2 { get; set; }

        public string cDLCode { get; set; }

        public string UserName { get; set; }

        public Dictionary<string,List<string>> cBatch { get; set; }
    }
}

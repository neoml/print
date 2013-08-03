using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace ServiceLib.Entity
{
    [Serializable]
    public class InvoiceRes
    {
        public string cBarCode { get; set; }

        public string cPosCode { get; set; }

        public float iQuantity { get; set; }

        public float iFQuantity { get; set; }

        public string cFree1 { get; set; }

        public string cFree2 { get; set; }

        public string cDLCode { get; set; }

        public string UserNum { get; set; }

        public float inQuantity{ get; set; }

        public string cInvCode { get; set; }

        public string cInvName { get; set; }

        public string cBatch { get; set; }
    }
}

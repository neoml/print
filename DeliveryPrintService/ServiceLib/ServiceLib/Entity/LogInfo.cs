using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace ServiceLib.Entity
{
    [Serializable]
     public class LogInfo
    {
         public string OperatorName { get; set; }

         public DateTime OperatorTime { get; set; }

         public string Remark { get; set; }

         public int status { get; set; }

         public string OrderNum { get; set; }

         public int MergerOrderId { get; set; }

         public string DepartmentNo { get; set; }

         public string OperatorNo { get; set; }

         public string userID { get; set; }

    }
}

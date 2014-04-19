using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestThread
{
   public  class Transaction
    {
      
        public DateTime CreationDate { get; set; }
        public long Id { get; set; }
        public int RequestId { get; set; }
        public string RequestXml { get; set; }
      
    }
}

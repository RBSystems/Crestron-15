using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KODIRPC.Setting.Details
{
   public class ControlBase
   {
       public bool delayed { get; set; }
       public string format { get; set; }
       public string type { get; set; }
    }
}

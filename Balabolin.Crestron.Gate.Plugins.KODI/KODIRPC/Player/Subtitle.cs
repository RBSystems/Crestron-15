using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KODIRPC.Player
{
   public class Subtitle
   {
       public int index { get; set; }
       public string language { get; set; }
       public string name { get; set; }
    }
}

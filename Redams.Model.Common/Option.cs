using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDataKit_Collect.Common
{
  public  class Option: Realms.RealmObject
    {

        public string Label { get; set; }

        public string Value { get; set; }
    }
}

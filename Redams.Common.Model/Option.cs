using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
  public  class Option: Realms.RealmObject
    {

        public string Label { get; set; }

        public string Value { get; set; }
    }
}

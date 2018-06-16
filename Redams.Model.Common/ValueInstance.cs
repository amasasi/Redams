using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDataKit_Collect.Common
{
public    class ValueInstance : Realms.RealmObject
    {
        [Realms.PrimaryKey]
        public string ID { get; set; }

        public string Value { get; set; }


        public Field FormElement { get; set; }
    }
}

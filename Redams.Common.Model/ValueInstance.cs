using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
public    class ValueInstance : Realms.RealmObject
    {
        [Realms.PrimaryKey]
        public string ID { get; set; }

        public string Value { get; set; }


        public Field FormElement { get; set; }
    }
}

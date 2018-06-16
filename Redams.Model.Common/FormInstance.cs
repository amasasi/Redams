using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDataKit_Collect.Common
{
public    class FormInstance : Realms.RealmObject
    {

        [Realms.PrimaryKey]
        public string ID { get; set; }


        public Form Form { get; set; }

        public FormInstance ParentFormInstance { get; set; }

        public IList<ValueInstance> ValueInstances { get; }
    }
}

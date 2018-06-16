using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
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

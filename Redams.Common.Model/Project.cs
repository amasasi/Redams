using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
  public  class Project : Realms.RealmObject
    {

        [Realms.PrimaryKey]
        public string ID { get; set; }

       public string ProjectName { get; set; }

        public IList<Form> Forms { get; }
       

        
        public FormInstance FormInstance { get ; set; }
    }
}

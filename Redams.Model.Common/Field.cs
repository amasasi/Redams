using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDataKit_Collect.Common
{
   public class Field :  Realms.RealmObject, IFormElement
    {

        public Form Form { get; set; }


        public Field ParentField { get; set; }

        [Realms.PrimaryKey]
        public string ID { get; set; }
        
        public string Type { get; set; }

        public  string Name { get; set; }

        public string StoreFieldName { get; set; }
        public string Label { get; set; }

        public string Relevant { get; set; }

        public IList<Option> Options { get; }


        public IList<Field> Fields { get; }



     
       
        public FormInstance FormInstance { get; set; }
    }
}

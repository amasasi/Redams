using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model.DAL
{
   public class Field
    {

      


        

        public string ID { get; set; }
        
        public string Type { get; set; }

        public  string Name { get; set; }

        public string StoreFieldName { get; set; }
        public string Label { get; set; }

        public string Relevant { get; set; }

        public IList<Option> Options { get; }


        public IList<Field> Fields { get; }



     
       
      
    }
}

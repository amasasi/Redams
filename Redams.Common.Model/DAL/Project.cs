using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model.DAL
{
  public  class Project
    {


        public string ID { get; set; } = Guid.NewGuid().ToString();

       public string ProjectName { get; set; }


        public string ShortName { get; set; }
        public IList<Form> Forms { get; } = new List<Form>();

       

        
        
    }
}

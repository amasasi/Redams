using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
    public class Form : Realms.RealmObject, IFormElement
    {
     

        public IList<Field> Fields
        { get; }

    }
}

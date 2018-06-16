using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDataKit_Collect.Common
{
    public class Form : Realms.RealmObject, IFormElement
    {
     

        public IList<Field> Fields
        { get; }

    }
}

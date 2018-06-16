using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
    public class SafeRealmConfiguration : Realms.RealmConfiguration
    {
        public SafeRealmConfiguration(string path) : base(path)
        {

            SchemaVersion = 19;

        }
    }
}

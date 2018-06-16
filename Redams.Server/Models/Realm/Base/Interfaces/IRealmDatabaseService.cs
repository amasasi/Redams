using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redams.Server.Models.Realm.Base.Interfaces
{
    public interface IRealmDatabaseService
    {
        void Commit();
        Realms.Realm Realm { get; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Redams.Server.Models.Realm.Base
{
    public class MainDbRealmDatabaseService : RealmDatabaseService<MainDbRealmDatabaseService>, IMainDbRealmDatabaseService
    {


        protected override void InitializeDb()
        {




            var path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "MainDatabase", "MainDb.realm");
            var conf = new Common.Model.SafeRealmConfiguration(path);


            _Realm = Realms.Realm.GetInstance(conf);
         








           
        }



    }
}

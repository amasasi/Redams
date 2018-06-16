using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realms;

namespace Redams.Server.Models.Realm.Base
{
    public class RealmDatabaseService<T> : Interfaces.IRealmDatabaseService, IDisposable
    {


        protected virtual void InitializeDb()
        {

        }



        public void Commit()
        {
            realmTransaction.Commit();
        }

        private bool rollback = false;

        public void Dispose()
        {
            try
            {
                if (!rollback)
                {
                    realmTransaction.Commit();
                }
                realmTransaction.Dispose();
                _Realm.Dispose();
                _Realm = null;
                realmTransaction = null;
            }
            catch
            {

            }


        }

        [ThreadStatic]
        protected static Realms.Realm _Realm;

        [ThreadStatic]
        protected static Realm.Base.RealmTransaction realmTransaction;
        public Realms.Realm Realm
        {
            get
            {
                if (_Realm == null)
                {
                    InitializeDb();
                    realmTransaction = new Realm.Base.RealmTransaction(this);
                    realmTransaction.SetTransaction(_Realm.BeginWrite());
                }

                return _Realm;
            }
        }

      
    }
}

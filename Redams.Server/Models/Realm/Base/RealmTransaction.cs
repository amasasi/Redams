using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redams.Server.Models.Realm.Base
{
    public class RealmTransaction :  IDisposable
    {

        private Realms.Transaction _transaction;

        Models.Realm.Base.Interfaces.IRealmDatabaseService realmDatabaseService;

        public RealmTransaction(Models.Realm.Base.Interfaces.IRealmDatabaseService RealmDatabaseService)
        {
            this.realmDatabaseService = RealmDatabaseService;
        }

        public void Commit()
        {
            try
            {
                if (_transaction != null)
                    _transaction.Commit();
            }
            catch
            {

            }


            if (this.realmDatabaseService.Realm != null && !this.realmDatabaseService.Realm.IsInTransaction)
                SetTransaction(this.realmDatabaseService.Realm.BeginWrite());

        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();
        }

        public void RollBack()
        {

            _transaction.Rollback();
        }

        public void SetTransaction( Realms.Transaction transaction)
        {
            _transaction = transaction;
        }
    }
}

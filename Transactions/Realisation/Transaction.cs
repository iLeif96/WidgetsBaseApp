using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects.Comparing;

namespace iLeif.Transactions.Realisation
{
    internal abstract class Transaction<TMember> : ITransaction<TMember> where TMember : ITransactionAble
    {
        public event EventHandler OnDispose;
        public event EventHandler<PropertiesInfo<TMember>> OnCommit;

        private Guid _id = Guid.NewGuid();
        public Guid Id => _id;
        public abstract bool IsWriteTransaction { get; }

        public ITransactionManager<TMember> TransactionManager { get; }

        public Transaction(ITransactionManager<TMember> trManager)
        {
            TransactionManager = trManager;
        }

        public virtual void Commit() => Dispose();

        public abstract ITransactionMember<TMember> GetMember(Guid memberId);
        public void Dispose() => OnDispose.Invoke(this, new EventArgs());
    }
}

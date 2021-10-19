using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects;
using iLeif.Transactions;

namespace iLeif.Transactions.Realisation
{
    internal class ReadTransaction<TMember> : Transaction<TMember> where TMember : ITransactionAble
    {

        public override bool IsWriteTransaction { get; } = false;
        public ReadTransaction(ITransactionManager<TMember> trManager) : base(trManager)
        {

        }

        public override ITransactionMember<TMember> GetMember(Guid memberId)
        {
            return TransactionManager.TryGetMember(memberId, out TMember member)
                ? new TransactionMember<TMember>((TMember)member.Clone(), true)
                : default;
        }
    }

    internal class WriteTransaction<TMember> : Transaction<TMember> where TMember : ITransactionAble
    {
        private Dictionary<Guid, TMember> _inTransaction = new Dictionary<Guid, TMember>();
        public override bool IsWriteTransaction { get; } = true;
        public WriteTransaction(ITransactionManager<TMember> trManager) : base(trManager)
        {
        }
        public override ITransactionMember<TMember> GetMember(Guid memberId)
        {
            if (TransactionManager.TryGetMember(memberId, out TMember member))
            {
                var cloned = (TMember)member.Clone();
                _inTransaction.Add(memberId, cloned);
                return new TransactionMember<TMember>(cloned, true);
            }

            return default;
        }
        public override void Commit()
        {
            //Write code
            foreach (var cloned in _inTransaction)
            {
                if (TransactionManager.TryGetMember(cloned.Key, out TMember orig))
                {
                    var diffs = cloned.Value.Compare(orig);
                    if (diffs.Count > 0)
                    {
                        //TODO: Add notifications to subscribers
                        diffs.ApplyToObject(orig);

                    }
                }
            }

            Dispose();
        }
    }
}
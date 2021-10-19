using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Transactions;

namespace iLeif.Transactions.Realisation
{
    internal class TransactionMember<TMember> : ITransactionMember<TMember> where TMember : ITransactionAble
    {
        public TMember Member { get; }
        public Guid Id { get; }
        public bool IsOpenedForWrite { get; }

        public TransactionMember(TMember member, bool isOpenedForWrite)
        {
            Member = (TMember)member.Clone();
            IsOpenedForWrite = isOpenedForWrite;
            Id = Member.Id;
        }
    }
}

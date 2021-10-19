using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects.Comparing;

namespace iLeif.Transactions
{
    public interface ITransaction<TMember> : IDisposable where TMember : ITransactionAble
    {
        event EventHandler OnDispose;
        event EventHandler<PropertiesInfo<TMember>> OnCommit;
        ITransactionManager<TMember> TransactionManager { get; }
        bool IsWriteTransaction { get; }
        Guid Id { get; }

        ITransactionMember<TMember> GetMember(Guid memberId);

        void Commit();
    }
}

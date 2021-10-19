using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Transactions
{
    public interface ITransactionManager<TMember> where TMember : ITransactionAble
    {
        event EventHandler<TMember> DataChanged;
        void AddMembersData(params TMember[] members);
        bool TryGetMember(Guid id, out TMember member);

        ITransaction<TMember> OpenForRead();
        ITransaction<TMember> OpenForWrite();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Arrays;
using iLeif.Transactions;

namespace iLeif.Transactions.Realisation
{
    public class TransactionManager<TMember> : ITransactionManager<TMember> where TMember : ITransactionAble
    {
        public event EventHandler<TMember> DataChanged;

        public Dictionary<Guid, TMember> _dataMembers = new Dictionary<Guid, TMember>();
        private Dictionary<Guid, ITransaction<TMember>> _transactions = new Dictionary<Guid, ITransaction<TMember>>();

        public TransactionManager() { }
        public TransactionManager(params TMember[] members)
        {
            AddMembersData(members);
        }

        public void AddMembersData(params TMember[] members) => members.ForEach(m => _dataMembers.Add(m.Id, m));
        public bool TryGetMember(Guid id, out TMember member) => _dataMembers.TryGetValue(id, out member);

        public ITransaction<TMember> OpenForRead()
        {
            ITransaction<TMember> readTr = new ReadTransaction<TMember>(this);

            _transactions.Add(readTr.Id, readTr);
            return readTr;
        }
        public ITransaction<TMember> OpenForWrite()
        {
            ITransaction<TMember> writeTr = new WriteTransaction<TMember>(this);

            _transactions.Add(writeTr.Id, writeTr);
            return writeTr;
        }
    }
}

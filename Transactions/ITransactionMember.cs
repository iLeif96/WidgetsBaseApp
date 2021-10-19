using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Transactions
{
    public interface ITransactionMember<TMember> where TMember : ITransactionAble
    {
        /// <summary>
        /// This is visable cloned member that user can read and edit
        /// </summary>
        TMember Member { get; }
        Guid Id { get; }
        bool IsOpenedForWrite { get; }
    }
}

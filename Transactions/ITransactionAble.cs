using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Transactions
{
    public interface ITransactionAble : ICloneable
    {
        Guid Id { get; }
    }
}

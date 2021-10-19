
using System;

using iLeif.Transactions;
using iLeif.Graphic;
using iLeif.MVP;

namespace iLeif.Environment
{
    public interface IEnvViewState : ITransactionAble
    {
        Size Size { get; set; }
        bool IsActive { get; set; }
        bool IsCollapced { get; set; }

        string Name { get; set; }
        string Description { get; set; }
    }
}

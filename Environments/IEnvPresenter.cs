using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.MVP;
using iLeif.Graphic;
using iLeif.Transactions;

namespace iLeif.Environment
{
    public interface IEnvPresenter<TView, TViewState> : IPresenter where TView : IEnvView<TViewState> where TViewState : IEnvViewState
    {
        ITransaction<TViewState> ReadViewState(TView view);
        ITransaction<TViewState> WriteViewState(TView view);

        bool TryGetView(TView view, out TViewState viewState);
    }
}

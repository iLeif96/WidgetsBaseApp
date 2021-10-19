using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using iLeif.Graphic;
using iLeif.MVP;
using iLeif.Transactions.Realisation;
using iLeif.Transactions;

namespace iLeif.Environment.EnvBases
{
    public abstract class BaseEnvPresenter<TView, TViewState>
        : IEnvPresenter<TView, TViewState> where TView : EnvViewBase<TViewState> where TViewState : EnvViewStateBase
    {
        private IModel _model;
        private Dictionary<TView, TViewState> _views = new Dictionary<TView, TViewState>();
        private ITransactionManager<TViewState> _trManager = new TransactionManager<TViewState>();



        public void AttachModel(IModel model) => _model = model;

        public abstract void AddView(IView view);

        public abstract void OnInit();
        public abstract void OnModelUpdate();
        public abstract void OnViewUpdate();

        public abstract ITransaction<TViewState> ReadViewState(TView view);
        public abstract ITransaction<TViewState> WriteViewState(TView view);
        public abstract bool TryGetView(TView view);
    }
}


using iLeif.MVP;

namespace iLeif.Environment
{
    public interface IEnvView<TEnvStateView> : IView where TEnvStateView : IEnvViewState
    {

    }
}

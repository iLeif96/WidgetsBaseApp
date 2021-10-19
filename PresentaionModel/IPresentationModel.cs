using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.PresentaionModel
{
    public interface IPresentationModel<TModel, TStateModel, TView> where TModel : IModel where TStateModel : IViewStateModel where TView : IVIew
    {

    }
}

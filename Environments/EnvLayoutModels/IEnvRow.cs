namespace iLeif.Environment.EnvLayoutModels
{
    public interface IEnvRow : IEnvAbsoluteLayout, IEnvRelativeLayout
    {
        void AddBreak();
    }
}

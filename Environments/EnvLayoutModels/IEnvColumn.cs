namespace iLeif.Environment.EnvLayoutModels
{
    public interface IEnvColumn : IEnvAbsoluteLayout, IEnvRelativeLayout
    {
        void AddBreak();
    }
}

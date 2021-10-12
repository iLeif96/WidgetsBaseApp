namespace iLeif.Environments.EnvLayouts
{
    public interface IEnvColumn : IEnvAbsoluteLayout, IEnvRelativeLayout
    {
        void AddBreak();
    }
}

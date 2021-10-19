namespace iLeif.Environment.EnvViewStates.Extensions
{
    public interface IEnvText
    {
        IEnvViewState<string> Text { get; set; }
        bool IsTextUsing { get; set; }
    }
}

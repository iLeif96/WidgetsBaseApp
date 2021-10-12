namespace iLeif.Environments.EnvModels.Extensions
{
    public interface IEnvIco : IEnvModel
    {
        double IcoWidth { get; set; }
        double IcoHeigth { get; set; }
        string URL { get; set; }
        bool IsIcoUsing { get; set; }
    }
}

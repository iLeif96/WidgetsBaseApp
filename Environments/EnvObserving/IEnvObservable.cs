namespace iLeif.Environments.EnvObserving
{
    public interface IEnvObservable
    {
        void RegisterObserver(IEnvObserver observer);
        void RemoveObserver(IEnvObserver observer);
        void NotifyObservers();
    }
}

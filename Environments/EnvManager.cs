using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environment
{
    public class EnvManager
    {
        private readonly Dictionary<string, IEnvironment> _environments = new Dictionary<string, IEnvironment>();

        public EnvManager()
        {
            FindEnvironments();
        }

        public void AddEnvironment(IEnvironment env) => _environments.Add(env.Name, env);
        public bool RemoveEnvironment(IEnvironment env) => _environments.Remove(env.Name);
        public bool GetEnvironment(string envName, out IEnvironment env) => _environments.TryGetValue(envName, out env);

        private void FindEnvironments()
        {

        }

        public IEnvPresentatorsFactory CreateFactory<TEnv>() where TEnv : IEnvironment, new()
        {
            return TEnv;
        }
    }
}

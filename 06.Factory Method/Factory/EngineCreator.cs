using System.Collections.Generic;

namespace _06.Factory_Method.Factory
{
    public class EngineCreator
    {
        private Dictionary<string, EngineFactory> engineFactorys;
        public EngineCreator()
        {
            InitializeDefaultEngineFactory();
        }

        private void InitializeDefaultEngineFactory()
        {
            engineFactorys = new Dictionary<string, EngineFactory>();
            engineFactorys.Add(nameof(GasolineEngineFactory), new GasolineEngineFactory());
            engineFactorys.Add(nameof(SolarEngineFactory), new SolarEngineFactory());
        }

        private void RegisterEngineFactory(string name, EngineFactory engineFactory)
        {
            if (!engineFactorys.ContainsKey(name))
            {
                engineFactorys.Add(name, engineFactory);
            }
        }

        public Engine Create(string name)
        {
            if (engineFactorys.TryGetValue(name, out EngineFactory engineFactory))
            {
                return engineFactory.MakeEngine();
            }
            else
            {
                return null;
            }
        }
    }
}

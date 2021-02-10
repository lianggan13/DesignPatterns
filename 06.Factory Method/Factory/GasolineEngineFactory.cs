namespace _06.Factory_Method.Factory
{
    public class GasolineEngineFactory : EngineFactory
    {
        public override Engine MakeEngine()
        {
            return new GasolineEngine();
        }
    }
}

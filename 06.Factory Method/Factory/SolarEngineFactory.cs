namespace _06.Factory_Method.Factory
{
    public class SolarEngineFactory : EngineFactory
    {
        public override Engine MakeEngine()
        {
            return new SolarEngine();
        }
    }
}

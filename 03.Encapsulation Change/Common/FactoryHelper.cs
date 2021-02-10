using System.Configuration;
using System.Reflection;

namespace _03.Encapsulation_Change.Common
{
    public static class FactoryHelper<T> where T : class
    {
        private static T instance = null;
        public static T Create(string typeNameKey, string nameSpace, string assemblyPath)
        {
            if (instance == null)
            {
                string typeName = ConfigurationManager.AppSettings[typeNameKey];
                string className = nameSpace + "." + typeName;

                instance = (T)Assembly.Load(assemblyPath).CreateInstance(className);
            }
            return instance;
        }
    }
}

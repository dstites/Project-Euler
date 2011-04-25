using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = FindDerivedTypesFromAssembly(Assembly.GetExecutingAssembly(), typeof (BaseProblem), true);
            foreach (var problemType in classes)
            {
                var problem = Assembly.GetExecutingAssembly().CreateInstance(problemType.ToString());
                if (problem != null)
                {
                    ((BaseProblem) problem).Run();
                }
            }
            Console.ReadKey();
        }

        public static IEnumerable<Type> FindDerivedTypesFromAssembly(Assembly assembly, Type baseType, bool classOnly)
        {
            if (assembly == null)
                throw new ArgumentNullException("assembly", "Assembly must be defined");
            if (baseType == null)
                throw new ArgumentNullException("baseType", "Parent Type must be defined");

            // get all the types
            var types = assembly.GetTypes();

            // works out the derived types
            foreach (var type in types.Where(type => !classOnly || type.IsClass))
            {
                if (baseType.IsInterface)
                {
                    var it = type.GetInterface(baseType.FullName);

                    if (it != null)
                        // add it to result list
                        yield return type;
                }
                else if (type.IsSubclassOf(baseType))
                {
                    // add it to result list
                    yield return type;
                }
            }
        }
    }
}

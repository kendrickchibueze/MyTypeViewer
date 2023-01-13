using System.Reflection;

namespace StaticMethodWithReflection
{

    //we are implementing reflection on static methods 
   public  class StaticMethods {

        //reflection on both the method parameters and return values
        public static void ListMethod(Type t)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods().OrderBy(m => m.Name).ToArray();
            foreach (MethodInfo m in mi)
            {
                // Get return type.
                string retVal = m.ReturnType.FullName;
                string paramInfo = "( ";
                // Get params.
                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0} {1} ", pi.ParameterType, pi.Name);
                }
                paramInfo += " )";
                // Now display the basic method sig.
                Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
            }
            Console.WriteLine();
        }





        // Display method names of type.
        public static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("->{0}", m.Name);
            }
            Console.WriteLine();
        }

        //static void ListMethods(Type t)
        //{
        //    Console.WriteLine("***** Methods *****");
        //    var methodNames = from n in t.GetMethods() orderby n.Name select n.Name;
        //    // Using LINQ extensions:
        //    // var methodNames = t.GetMethods().OrderBy(m=>m.Name).Select(m=>m.Name);
        //    foreach (var name in methodNames)
        //    {
        //        Console.WriteLine("->{0}", name);
        //    }
        //    Console.WriteLine();
        //}




        //reflection on fields and properties
        // Display field names of type.
        public static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            // var fieldNames = from f in t.GetFields() orderby f.Name select f.Name;
            var fieldNames = t.GetFields().OrderBy(m => m.Name).Select(x => x.Name);
            foreach (var name in fieldNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }


        // Display property names of type.
        public static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() orderby p.Name select p.Name;
            //var propNames = t.GetProperties().Select(p=>p.Name);
            foreach (var name in propNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }



        //relection on interfaces
        // Display implemented interfaces.
        public static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var ifaces = from i in t.GetInterfaces() orderby i.Name select i;
            //var ifaces = t.GetInterfaces().OrderBy(i=>i.Name);
            foreach (Type i in ifaces)
            {
                Console.WriteLine("->{0}", i.Name);
            }
        }

        // Just for good measure.
        public static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }



   
}
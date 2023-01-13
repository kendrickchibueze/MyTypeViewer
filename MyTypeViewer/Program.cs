
using StaticMethodWithReflection;
using System.Reflection;

namespace MyTypeViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to MyTypeViewer *****");
            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");
                // Get name of type.
                typeName = Console.ReadLine();

                // Does user want to quit?
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // Try to display type.
                try
                {
                 
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    StaticMethods.ListMethod(t);
                    StaticMethods.ListVariousStats(t);
                    StaticMethods.ListFields(t);
                    StaticMethods.ListProps(t);
                    StaticMethods.ListMethods(t);
                    StaticMethods.ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);

            Console.ReadLine();

        }

        //testing on the console(we get the meta data description of the following  types)
        //   System.Int32
        //•	 System.Collections.ArrayList
        //•	 System.Threading.Thread
        //•	 System.Void
        //•	 System.Math
    }
}
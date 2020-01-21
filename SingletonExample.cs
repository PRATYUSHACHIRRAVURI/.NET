using System;

namespace Pc
{
    public sealed class SingletonExample
    {
        private SingletonExample()
        {
             Console.WriteLine("This is called once");
            }
        private static SingletonExample instance=null;
        public static SingletonExample Instance
            {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonExample();
                }

                return instance;
            }
            }
    }
    class Program
    {
        public static void Main()
        {
            SingletonExample s1 = SingletonExample.Instance;
            SingletonExample s2 = SingletonExample.Instance;
            if(s1==s2)
            Console.WriteLine("As only once the instance is created this is singleton");
  
        }
    }
}
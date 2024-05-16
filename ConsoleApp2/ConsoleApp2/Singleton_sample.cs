using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    public class Singleton
    {
        // Private static instance variable
        private static Singleton instance;

        // Private constructor to prevent instantiation from outside
        private Singleton() { 
        }

        // Public static method to access the singleton instance
        public static Singleton GetInstance()
        {
            // Lazy initialization: create the instance if it doesn't exist
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Example method of the Singleton class
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    internal class Singleton_sample
    {
        static void Main(string[] args)
        {
            // Get the singleton instance
            Singleton singletonInstance = Singleton.GetInstance();
            // Use methods or properties of the singleton instance
            singletonInstance.PrintMessage("Hello, Singleton!");
        }
    }
}

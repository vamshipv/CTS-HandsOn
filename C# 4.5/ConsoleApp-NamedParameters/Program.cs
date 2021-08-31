using System;

namespace ConsoleApp_Named_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type 1
            GetCohortDetails("CDE-FSE", "20", "OBL", ".Net", "C#");

            // Type 2
            GetCohortDetails("24", "CDE-FSE", "OBL", "C#", ".Net");

            // Type 3
            GetCohortDetails(genCCount: "24", cohortName: "CDE-FSE", mode: "OBL", currentModule: "C#", track: ".Net");
            
            Console.ReadLine();
        }

        public static void GetCohortDetails(string cohortName, string genCCount, string mode, string track, string currentModule)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}", cohortName, genCCount, mode, track, currentModule);
        }
    }
}

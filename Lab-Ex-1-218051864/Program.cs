using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_Ex_1_218051864
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // declared the column names as lists
            List<string> lstYear = new List<string>(); 
            List<string> lstIndustryAgg = new List<string>(); 
            List<string> lstIndustryCode = new List<string>();
            List<string> lstUnits = new List<string>();
            List<string> lstVarCode = new List<string>();
            List<string> lstVarName = new List<string>();
            List<string> lstVariableCat = new List<string>();
            List<string> lstIndustryName = new List<string>();
            List<string> lstVal = new List<string>();
            List<string> lstCodeANZSI = new List<string>();
            
            // declaring the file
            var stReader = new StreamReader(@"../../financial-year.csv");

            // loop through file
            while (!stReader.EndOfStream)
            {
                var line = stReader.ReadLine();
                var val = line.Split(',');

             // here I search if the entry exists in the lists if yes then skip if not then add to the list   
                if (lstYear.Contains(val[0]))
                {
                } 
                else
                {
                    lstYear.Add(val[0]);
                }

                                
                if (lstIndustryAgg.Contains(val[1]))
                {
                }
                else
                {
                    lstIndustryAgg.Add(val[1]);
                }
                if (lstIndustryCode.Contains(val[2]))
                {
                }
                else
                {
                    lstIndustryCode.Add(val[2]);
                }
                if (lstIndustryName.Contains(val[3]))
                {
                }
                else
                {
                    lstIndustryName.Add(val[3]);
                }

                if (lstUnits.Contains(val[4]))
                {
                }
                else
                {
                    lstUnits.Add(val[4]);
                }

                if (lstVarCode.Contains(val[5]))
                {
                }
                else
                {
                    lstVarCode.Add(val[5]);
                }
                if (lstVarName.Contains(val[6]))
                {
                }
                else
                {
                    lstVarName.Add(val[6]);
                }
                if (lstVariableCat.Contains(val[7]))
                {
                }
                else
                {
                    lstVariableCat.Add(val[7]);
                }
               lstVal.Add(val[8]);
                if (lstCodeANZSI.Contains(val[9]))
                {
                }
                else
                {
                    lstCodeANZSI.Add(val[9]);
                }

            }
            // Disclaimer
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE DATA HAS BEEN CONSOLIDATED FOR EASE OF DISCERNMENT");
       
            
            // Displaying the Years
            Console.WriteLine("Years");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstYear.Count; i++)
            {
                Console.WriteLine("||{0,5} ||", lstYear[i]);
            }
            Console.WriteLine();

            //Displaying the Aggregation Level
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Industry Aggregation NZSIOC");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstIndustryAgg.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstIndustryAgg[i]);
            }
            Console.WriteLine();

            //Displaying the Industry Code 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Industry Code NZSIOC");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstIndustryCode.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstIndustryCode[i]);
            }
            Console.WriteLine();

            //Displaying the Industry Name 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Industry Name NZSIOC");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstIndustryName.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstIndustryName[i]);
            }
            Console.WriteLine();

            //Displaying the Units
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Units");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstUnits.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstUnits[i]);
            }
            Console.WriteLine();

            //Displaying the Variable Code
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Variable Code");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstVarCode.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstVarCode[i]);
            }
            Console.WriteLine();

            //Displaying the Variable Name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Variable Name");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstVarName.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstVarName[i]);
            }
            Console.WriteLine();

            //Displaying the Variable Category
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Variable Category");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstVariableCat.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstVariableCat[i]);
            }
            Console.WriteLine();

            //Displaying the Industry Code
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Industry Code ANZSIC06");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < lstCodeANZSI.Count; i++)
            {
                Console.WriteLine("||{0,5} ||",lstCodeANZSI[i]);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE DATA HAS BEEN CONSOLIDATED FOR EASE OF DISCERNMENT");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("- Lunghekani Langa 218051864");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
            
        }
    }
}
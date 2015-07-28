using System;
using System.Collections.Generic;

namespace NameCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = NameRepo.ReadNameList(@"../../names.txt");
            nameList.Sort();
            for (var i = 0; i < nameList.Count; i++)
            {
                //Assuming we wanted to start the positions in the list at 1 instead
                //of 0. I included the commented solution as a just in case to provide the alternative and start
                //the list positions at 0. 

                //Console.WriteLine(Calculator.CalculateName(nameList[i], i));
                Console.WriteLine(Calculator.CalculateName(nameList[i], i + 1));
            }
            Console.ReadLine();
        }
    }
}

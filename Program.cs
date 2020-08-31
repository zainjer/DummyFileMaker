using System;
using System.IO;

namespace DummyFileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filepath = "c:/dumdum/dummyFile.txt";
            string filepath= "";
            int size = 0;

            var options = GetOptionsFromUser();
            
            size = options.Item1;
            filepath = options.Item2;

            CreateFile(size,filepath);

        }

        private static (int, string) GetOptionsFromUser()
        {
            Console.WriteLine("Please enter dummy file size in MB");
            int size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the location you want file to be saved\n[Eg. C:/dummyFolder/dummyfile.txt] - Note: Do not use spaces in Location path");
            string filePath = Console.ReadLine();

            return (size,filePath);
        }


        static void CreateFile(int sizeInMB, string path)
        {        
            string x = "🤣";
            float countedByte = 5;
            float calc = (sizeInMB*(1048576/countedByte));
            float steps= MathF.Round(calc);
            System.Console.WriteLine("calc:"+calc);
            System.Console.WriteLine("step:"+steps);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                int status = 100000;
                int approxSize = 0;
                for(int i=0; i<=steps; i++)
                {
                    if(status < 1)
                    {
                        approxSize += 100;
                        System.Console.WriteLine(approxSize+" kb done");
                        status = 100000;

                    }
                    writer.Write(x);

                    status = status - 5;
                }
            }
        }
    }
}

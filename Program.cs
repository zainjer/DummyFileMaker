using System;
using System.IO;

namespace DummyFileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var filepath = "c:/dumdum/dummyFile.txt";

            CreateFile(2,filepath);

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
                for(int i=0; i<=steps; i++)
                {
                    if(status < 1)
                    {
                        System.Console.WriteLine("100 kb done");
                        status = 100000;
                    }
                    writer.Write(x);

                    status = status - 5;
                }
            }
        }
    }
}

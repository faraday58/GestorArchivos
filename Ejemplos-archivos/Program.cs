using System;
using System.IO;
namespace Ejemplos_archivos
{
    class Program
    {
        static void Main()
        {
            long offset;
            int nextbyte;
            // Archivo abcdh  :  "abcdefghijklmnopqrstuvwxyz"
            FileStream fs = new FileStream(@"C:\Users\Armando\Dropbox\TP\abcdh.txt", FileMode.Open, FileAccess.Read);

            for(offset = 1; offset <= fs.Length; offset++)
            {
                fs.Seek(-offset, SeekOrigin.End);
                Console.Write(Convert.ToChar(fs.ReadByte()));
            }

            Console.WriteLine();

            fs.Seek(20, SeekOrigin.Begin);

            while((nextbyte=fs.ReadByte()) >0)
            {
                Console.Write(Convert.ToChar(nextbyte));
            }
            Console.WriteLine();




        }
    }
}

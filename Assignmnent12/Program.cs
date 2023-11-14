using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File1 obj = new File1();
            int choose;
            Console.WriteLine("choose the operation \n 1 \t create \n 2 \t read (must contain abc.txt file in given path ith text to read) \n 3 \t append \n 4 \t delete");
            choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                obj.createfile();
            }
            else if (choose == 2)
            {
                obj.readfile();
            }
            else if (choose == 3)
            {
                obj.appendfile();
            }
            else if (choose == 4)
            {
                obj.deletefile();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("What is the name of the the document?");
            var name = Console.ReadLine();
            name = $"{name}.txt";
            Console.Write($"You have created a file named {name}");
            Console.WriteLine("What do you want to write to the document?");
            var text = Console.ReadLine();
            try
            {
                using (StreamWriter write = new StreamWriter(name))
                {
                    write.Write(text);
                }
                Console.WriteLine($"{name} is saved");
            }

            catch(Exception ex)
            {
                using (StreamWriter write = new StreamWriter("exception.txt"))
                    
                {
                    write.Write(text);
                }
                Console.WriteLine("Your file name does not work! The file is now called excepion.txt");
            }
            
            //Console.Write("\n");
          //  Console.ReadKey(true);
        }
    }
}

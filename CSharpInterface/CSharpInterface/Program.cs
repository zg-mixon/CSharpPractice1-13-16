using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            new Keyboard().PushButton("Space");
            new VirtualKeyboard().PushButton("Space");
            Console.ReadLine();
        }
    }
}

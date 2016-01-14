using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface
{
    interface IKeyboard {
        void PushButton(string buttonToPush);
    }
    class Keyboard : IKeyboard
    {
        public void PushButton(string buttonToPush) {
            Console.WriteLine(buttonToPush);
        }
    }

    class VirtualKeyboard : IKeyboard {
        public void PushButton(string butonToPush)
        {
            foreach (var letter in butonToPush) {
                Console.Write(letter);
            }
            Console.WriteLine();
        }

    }
}

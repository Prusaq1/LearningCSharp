using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Worm :Animal
    {
        public override void Speak()
        { Console.WriteLine("Don't speak");}
        public override void Moov()
        { Console.WriteLine("Craw");}
        public override void PreferredFood()
        { Console.WriteLine("Fish");}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_7
{
    public class Fish : Animal
    {
        public string name;
        public override void Speak()
        { Console.WriteLine("Буль-Bool"); }
        public override void Moov()
        {Console.WriteLine("Swim");}
        public override void PreferredFood()
        { Console.WriteLine("Worm"); }
    }
}
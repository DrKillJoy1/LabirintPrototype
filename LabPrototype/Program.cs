using System;

using LabPrototype.Test;

namespace LabPrototype
{
    static class Program
    {

        static void Main(string[] args)
        {
            using (MainGame game = new MainGame()) game.Run();
 
        }
    }
}


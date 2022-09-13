using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Shape[] shapes = new Shape[2];
                shapes[0] = new Circle(3, 5, "зелёного");
                shapes[1] = new Rectangle(6, 7, 6, 7, "красного");

                foreach (Shape shape in shapes)
                {
                    shape.draw();
                }
                Console.ReadKey();
            }

        }
    }
    
}

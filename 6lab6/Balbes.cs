using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6lab6
{
    public class Balbes
    {
        public string Name { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return $"Название:{Name}, " +
                $"Высота:{Height}, ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Chair
    {
        public int color { get; set; }
        public Chair(int _color)
        {
            color = _color;
        }
        public Chair(Chair c)
        {
            this.color = c.color;
        }
    }
}

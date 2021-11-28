using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wall
    {
        public int width { get; set; }
        public int Height { get; set; }
        public int Thickness { get; set; }
        //  constactor 
        public Wall(int _width, int _height, int _thickness)
        {
            width = _width;
            Height = _height;
            Thickness = _thickness;
        }

        //  copy constructor
        public Wall(Wall w)
        {
            width = w.width;
            Height = w.Height;
            Thickness = w.Thickness;
        }

    }
}

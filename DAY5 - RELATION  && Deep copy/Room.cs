using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Room
    {
        public int color { get; set; }
        private Wall w1;
        // composition 
        public Wall W1
        {
            get
            {
                return
                   new Wall(w1.width, w1.Height, w1.Thickness);

            }
            set
            {
                w1 = new Wall(value.width, value.Height, value.Thickness);

            }
        }
        public Wall w2 { get; set; }
        //  aggraction

        public Chair c1 { get; set; }
        public Room(Wall _w1, Wall _w2, Chair c)
        {
            w1 = new Wall(_w1.width, _w1.Height, _w1.Thickness);
            w2 = new Wall(_w2);

            c1 = c;
        }
        //    Associate 
        public void PrintWhoTeach(Instructor i)
        {
            Console.WriteLine(i.Name);
        }
        // public Wall[] walls   // new int [] com   chairs =_chairs // agg



    }
}

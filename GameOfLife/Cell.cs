using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife
{
    public class Cell
    {
        bool IsAlive;
        //Point mPos;

        //public Cell(bool _Alive)
        //{
        //    //mPos = _P;
        //    IsAlive = _Alive;
        //}


        //public Point _Pos
        //{
        //    get { return mPos; }
        //    set { mPos = value; }
        //}

        public bool Alive
        {
            get { return IsAlive; }
            set { IsAlive = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESA_Projekt
{
    public struct Position
    {
        public int h;
        public int x;
        public int y;

        public Position(int x, int y, int h)
        {
            this.x = x;
            this.y = y;
            this.h = h;
        }

        public void PositionÄndern(int deltaX, int deltaY, int deltaH)
        {
            x = x + deltaX;
            y = y + deltaY;
            h = h + deltaH;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESA_Projekt
{
    public interface ITranspond
    {
        void Transpond(string kennung, Position pos);
    }
}
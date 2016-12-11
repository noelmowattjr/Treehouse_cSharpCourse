using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_classes
{
    class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException(string msg) : base(msg)
        {

        }
    }

    class OutOfBoundsExeption : TreehouseDefenseException
    {
        public OutOfBoundsExeption(string msg) : base(msg)
        {

        }
    }
}

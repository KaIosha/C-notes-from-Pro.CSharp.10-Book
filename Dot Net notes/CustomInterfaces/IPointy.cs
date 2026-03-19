using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal interface IPointy
    {
        //public int numbOfPoints;//Error
        byte GetNumberOfPoints();
        string PropName { get; set; }
        byte Points { get; }
    }
}

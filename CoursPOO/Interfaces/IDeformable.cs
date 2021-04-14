using CoursPOO.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Interfaces
{
    interface IDeformable
    {
        Figure Deformation(double coeffH, double coeffV);
    }
}

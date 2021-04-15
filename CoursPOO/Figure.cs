using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO
{ 
public abstract class Figure
{
    // coordonnée
    private int posX;
    private int posY;
    public Figure(int x, int y)
    {
        posX = x;
        posY = y;
    }

}
}
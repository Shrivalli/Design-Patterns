using System;

namespace FacadeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMakerFacade facade = new ShapeMakerFacade();
            facade.DrawCircle();
            facade.DrawRectangle();
            facade.DrawSquare();
        }
    }
}

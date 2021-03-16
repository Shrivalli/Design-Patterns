namespace FacadeDP
{
    class ShapeMakerFacade
    {
        private readonly IShape circle;
        private readonly IShape rectangle;
        private readonly IShape square;

        public ShapeMakerFacade()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }
        public void DrawCircle()
        {
            circle.Draw();

        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}

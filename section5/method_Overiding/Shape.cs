namespace method_Overiding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the circle itself

            base.Draw();
        }

    }

    public class Rectangle : Shape
    {
        
    }

    public class Triangle : Shape
    {
        
    }

    public class Shape
    {
        public int Width { get; set }
        public int Height { get; set }
        public Position Position { get; set }
        // public ShapeType Type { get; set }

        public virtual void Draw()
        {

        }
    }
}
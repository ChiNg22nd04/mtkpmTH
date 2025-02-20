internal class Program
{
    static void Main(string[] args)
    {
		Console.WriteLine("***Adapter Pattern Modified Demo***\n");
		//CalculatorAdapter cal = new CalculatorAdapter();
		Rectangle r = new Rectangle(20, 10);
		Console.WriteLine("Area of Rectangle is :{0} Square unit", r.CalculateArea());
		Triangle t = new Triangle(20, 10);
		Console.WriteLine("Area of Triangle is :{0} Square unit", t.CalculateAreaOfTriangle());
		IRectangle adapter = new RectangleAdapter(t);
		//Passing a Triangle instead of a Rectangle
		Console.WriteLine("Area of Triangle using the triangle adapter is :{0} Square unit", GetArea(adapter));
    }

	static double GetArea(IRectangle r) {
		r.AboutMe();
 		return r.CalculateArea();
	}
}
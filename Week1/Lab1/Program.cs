internal class Program
{
    private static void Main(string[] args)
    {
		Point2D point1 = new Point2D();
		point1.Input();
		
		Point2D point2 = new Point2D();
		point2.Input();

		Console.WriteLine("Toa do diem A1: " + point1.ToString());
		Console.WriteLine("Toa do diem A2: " + point2.ToString());

		point1.Move(5,2);
		Console.WriteLine("Di chuyen diem A1 den toa do moi: " + point1.ToString());

		if (point1.isOrigin()) Console.WriteLine("Diem A1 la goc toa do");
		else Console.WriteLine("Diem A1 khong phai la goc toa do");

		Point2D p = new Point2D();
		p.Input();
		Console.WriteLine("Toa do diem p: " + p.ToString());
		Console.WriteLine("Khoang cach tu diem A1 toi diem p: " + point1.Distance(p));
		Console.WriteLine("Khoach cach giua 2 diem A1 va A2 la: " + Point2D.Distance(point1,point2));

    }
}
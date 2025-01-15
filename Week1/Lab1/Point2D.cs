class Point2D {
	public int x, y;
	public Point2D() { }
	public Point2D(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public Point2D(Point2D p) {
		this.x = p.x;
		this.y = p.y;
	}
	public void Input() {
		Console.WriteLine("Nhap toa do cho diem: ");
		Console.Write("x: ");
		x = int.Parse(Console.ReadLine());
		Console.Write("y: ");
		y = int.Parse(Console.ReadLine());
	}
	public string ToString() => $"({x},{y})";
	public void Move(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public bool isOrigin() {
		if (x == 0 && y == 0) return true;
		else return false;
	}
	public double Distance(Point2D p) {
		double kc = Math.Pow((p.x - this.x), 2) + Math.Pow((p.y - this.y), 2);
		return Math.Sqrt(kc);
	}
	public static double Distance(Point2D p1, Point2D p2) {
		double kc = Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2);
		return Math.Sqrt(kc);
	}
}
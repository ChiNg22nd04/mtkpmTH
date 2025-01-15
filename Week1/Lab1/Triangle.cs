class Triangle {
	private Point2D p1, p2, p3;
	public Triangle(Point2D p1, Point2D p2, Point2D p3) {
		this.p1 = p1;
		this.p2 = p2;
		this.p3 = p3;
	}
	public double Perimeter()
		=> Point2D.Distance(p1, p2) + Point2D.Distance(p2, p3) + Point2D.Distance(p3, p1);
	public double Area() {
		double p = Perimeter() / 2;
		double area = p * (p - Point2D.Distance(p1, p2)) * (p - Point2D.Distance(p2, p3)) * (p - Point2D.Distance(p1, p3));
		return Math.Round(Math.Sqrt(area), 2);
	}
}
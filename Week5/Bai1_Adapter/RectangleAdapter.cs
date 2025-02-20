class RectangleAdapter : IRectangle {
	Triangle triangle;//Adaptee
 	public RectangleAdapter(Triangle t) {
		this.triangle = t;
	}
 	public void AboutMe() {
		triangle.AboutTriangle();
	}
	public double CalculateArea() {
		return triangle.CalculateAreaOfTriangle();
	}
}
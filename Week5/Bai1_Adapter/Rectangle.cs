class Rectangle : IRectangle {
	public double Length;
	public double Width;
	public Rectangle(double l, double w) {
		this.Length = l;
		this.Width = w;
	}
	public double CalculateArea() {
		return Length * Width;
	}
 	public void AboutMe() {
		Console.WriteLine(" Actually, I am a Rectangle");
	}
	
}
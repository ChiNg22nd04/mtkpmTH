class Triangle : ITriangle {
	public double BaseLength;//base
 	public double Height;//height
 	public Triangle(double b, double h) {
		this.BaseLength = b;
		this.Height = h;
	}
	public double CalculateAreaOfTriangle() {
		return 0.5 * BaseLength * Height;
	}
	public void AboutTriangle() {
		Console.WriteLine("Actually, I am a Triangle");
	}
}
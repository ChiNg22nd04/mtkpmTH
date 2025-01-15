using System.Security.Cryptography.X509Certificates;
class Laptop : Computer {
	private double weight;
	public double Weight {
		set {
			if (value < 1) this.weight = 1;
			else this.weight = value;
		}
		get {
			return weight;
		}
	}
	public Laptop() : base() => weight = 1;
	public Laptop(string maMay, string tenMay, int namSX, double gia, double weight) : base(maMay, tenMay, namSX, gia) {
		Weight = weight;
	}
	public override void Input() {
		base.Input();
		Console.Write("Trong luong: ");
		Weight = double.Parse(Console.ReadLine());
	}
	public override void Output() {
		base.Output();
		Console.WriteLine($"Trong luong: {Weight}");
	}


}

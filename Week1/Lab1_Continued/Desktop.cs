using System.Security.Cryptography.X509Certificates;

class Desktop : Computer {
	private int namBH;
	public int NamBH {
		set {
			if (value < 0) this.namBH = 0;
			else this.namBH = value;
		}
		get {
			return namBH;
		}
	}
	public Desktop() : base() => namBH = 0;
	public Desktop(string maMay, string tenMay, int namSX, double gia, int namBH) : base(maMay, tenMay, namSX, gia) {
		NamBH = namBH;
	}
	public override void Input() {
		base.Input();
		Console.Write("Nam bao hanh: ");
		NamBH = int.Parse(Console.ReadLine());
	}
	public override void Output() {
		base.Output();
		Console.WriteLine($"Nam bao hanh: {NamBH}");
	}


}

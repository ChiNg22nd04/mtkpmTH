class Computer {
	private string maMay, tenMay;
	private int namSX;
	private double gia;
	public string MaMay {
		set => maMay = value;
		get => maMay;
	}
	public string TenMay {
		set => tenMay = value;
		get => tenMay;
	}

	public int NamSX {
		set {
			if (value < 1970) this.namSX = 1970;
			else namSX = value;
		}
		get {
			return namSX;
		}
	}
	public double Gia {
		set {
			if (value < 0) this.gia = 0;
			else this.gia = value;
		}
		get {
			return gia;
		}
	}

	public Computer() {
		MaMay = "";
		TenMay = "";
		NamSX = 1970;
		Gia = 0;
	}
	public Computer(string maMay, string tenMay, int namSX, double gia) {
		MaMay = maMay;
		TenMay = tenMay;
		NamSX = namSX;
		Gia = gia;
	}
	public virtual void Input() {
		Console.WriteLine("Nhap thong tin may: ");
		Console.Write("Ma may: ");
		MaMay = Console.ReadLine();
		Console.Write("Ten may: ");
		TenMay = Console.ReadLine();
		Console.Write("Nam san xuat: ");
		NamSX = int.Parse(Console.ReadLine());
		Console.Write("Gia: ");
		Gia = double.Parse(Console.ReadLine());
	}
	public virtual void Output() 
		=> Console.WriteLine($"Ma may: {MaMay} | Ten may: {TenMay} | Nam san xuat: {NamSX} | Gia: {Gia}");
	public void Running() => Console.WriteLine($"{TenMay} is running...");
}
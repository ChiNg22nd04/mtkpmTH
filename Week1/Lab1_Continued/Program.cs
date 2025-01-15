internal class Program
{
    private static void Main(string[] args)
    {
		Console.Write("Nhap so luong may tinh: ");
		int n = int.Parse(Console.ReadLine());
		Computer[] arrC = new Computer[n];
		for (int i = 0; i < n; i++) {
			Console.Write("Chon loai may: “D” de chon Desktop, nguoc lai la Laptop. ");
			string choose = Console.ReadLine();
			if (choose == "D" || choose == "d") {
				Desktop desktop = new Desktop();
				desktop.Input();
				arrC[i] = desktop;
			}
			else {
				Laptop laptop = new Laptop();
				laptop.Input();
				arrC[i] = laptop;
			}
		}
		Console.WriteLine("-----------------------------");
		Console.WriteLine("Thong tin cac may tinh: ");
		for (int i = 0; i < n; i++) {
			arrC[i].Output();
			if (arrC[i] is Laptop) {
				Laptop _laptop = (Laptop)arrC[i];
				_laptop.Running();
			}
		}
		Console.WriteLine("-----------------------------");
		double sum = 0;
		for (int i = 0; i < n; i++) {
			sum += arrC[i].Gia;
		}
		Console.WriteLine($"Tong gia tri cua tat ca cac may tinh la: {sum}");
		for (int i = 0; i < n; i++) {
			sum += arrC[i].Gia;
		}
		Console.WriteLine("-----------------------------");
		Console.WriteLine("Cac may Desktop co so nam bao hanh it hon 3: ");
		for (int i = 0; i < n; i++) {
			if (arrC[i] is Desktop && (arrC[i] as Desktop).NamBH < 3) {
				Desktop _desktop = (Desktop)arrC[i];
				Console.WriteLine($"Ma may: {_desktop.MaMay}");
			}
		}
    }
}
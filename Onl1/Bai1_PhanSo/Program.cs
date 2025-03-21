internal class Program
{
    private static void Main(string[] args)
    {
		Console.WriteLine("Nhập phân số a: ");
		Console.Write("Nhập tử số: ");
		int aTu = Convert.ToInt32(Console.ReadLine());
		Console.Write("Nhập mẫu số: ");
		int aMau = Convert.ToInt32(Console.ReadLine());
		PhanSo a = new PhanSo(aTu, aMau);

		Console.WriteLine("Nhập phân số b: ");
		Console.Write("Nhập tử số: ");
		int bTu = Convert.ToInt32(Console.ReadLine());
		Console.Write("Nhập mẫu số: ");
		int bMau = Convert.ToInt32(Console.ReadLine());
		PhanSo b = new PhanSo(bTu, bMau);

		Console.WriteLine("Phép cộng 2 phân số trên: ");
		PhanSo add = a + b;
		add.Print();
		Console.WriteLine("Phép trừ 2 phân số trên: ");
		PhanSo sub = a - b;
		sub.Print();
		Console.WriteLine("Phép nhân 2 phân số trên: ");
		PhanSo multi = a * b;
		multi.Print();
		Console.WriteLine("Phép chia 2 phân số trên: ");
		PhanSo div = a / b;
		div.Print();

		if(a > b)
			Console.WriteLine("Phân số a > b");
		if(a < b)
			Console.WriteLine("Phân số a < b");

    }
}
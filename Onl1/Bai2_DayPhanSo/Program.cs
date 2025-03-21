internal class Program
{
    private static void Main(string[] args)
    {
		Console.Write("Nhập số lượng phần tử của dãy: ");
		int slpt = Convert.ToInt32(Console.ReadLine());
		DayPhanSo arr = new DayPhanSo(slpt);
		arr.InitArr();
		arr.Print();
		Console.Write("Tổng của dãy số là: ");
		arr.AddArr().Print();
    }
}
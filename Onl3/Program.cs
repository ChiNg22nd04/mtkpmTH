internal class Program
{
    private static void Main(string[] args)
    {
		Console.Write("Nhập số tiền cần đổi: ");
        int amount = int.Parse(Console.ReadLine());
        // Tạo chuỗi trách nhiệm (Chain of Responsibility)
        IBanknoteHandler h100 = new HundredHandler();
        IBanknoteHandler h50 = new FiftyHandler();
        IBanknoteHandler h20 = new TwentyHandler();
        IBanknoteHandler h10 = new TenHandler();
        IBanknoteHandler h5 = new FiveHandler();
        IBanknoteHandler h2 = new TwoHandler();
        IBanknoteHandler h1 = new OneHandler();
        // Nối chuỗi xử lý từ lớn đến nhỏ
        h100.SetNextHandler(h50);
        h50.SetNextHandler(h20);
        h20.SetNextHandler(h10);
        h10.SetNextHandler(h5);
        h5.SetNextHandler(h2);
        h2.SetNextHandler(h1);
        // Bắt đầu xử lý
        h100.Handle(amount);
	}
}
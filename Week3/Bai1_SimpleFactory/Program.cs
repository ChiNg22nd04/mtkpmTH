internal class Program
{
    private static void Main(string[] args)
    {
		Console.WriteLine("*** Simple Factory Pattern Demo ***\n");
        SimpleFactory simpleFactory = new SimpleFactory();
        try {
            // Gọi factory để tạo object dựa trên lựa chọn của người dùng
            IAnimal preferredType = simpleFactory.CreateAnimal();
            // Thực thi phương thức Speak()
            preferredType.Speak();

        } catch (ApplicationException ex) {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
        Console.WriteLine("\nChương trình kết thúc. Nhấn phím bất kỳ để thoát...");
    }
}
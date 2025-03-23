internal class Program
{
    private static void Main(string[] args)
    {
        Point2D p1 = new Point2D();
        Console.WriteLine("Điểm p1: " + p1.ToString());
        // Tạo điểm có tọa độ cụ thể
        Point2D p2 = new Point2D(3, 4);
        Console.WriteLine("Điểm p2: " + p2.ToString());
        // Nhập điểm mới từ bàn phím
        Point2D p3 = new Point2D();
        p3.Input();
        Console.WriteLine("Điểm p3: " + p3.ToString());
        // Di chuyển điểm p1
        p1.Move(5, 6);
        Console.WriteLine("Sau khi di chuyển, p1: " + p1.ToString());
        // Kiểm tra p1 có phải gốc tọa độ không
		if(p1.IsOrigin()) 
        	Console.WriteLine("p1 là gốc tọa độ");
		else
        	Console.WriteLine("p1 không phải là gốc tọa độ");
        // Tính khoảng cách giữa p2 và p3
        Console.WriteLine($"Khoảng cách từ {p2.ToString()} đến {p3.ToString()}: {p2.Distance(p3):F2}");
        // Tính khoảng cách giữa p1 và p2 (hàm tĩnh)
        Console.WriteLine($"Khoảng cách giữa {p1.ToString()} và {p2.ToString()}: {Point2D.Distance(p1, p2):F2}");
    }
}
class Point2D {
	private int x, y;
    // Constructor mặc định: Điểm tại gốc tọa độ (0,0)
    public Point2D(){
        x = 0;
        y = 0;
    }
    // Constructor có tham số: Khởi tạo điểm với tọa độ (x, y)
    public Point2D(int x, int y){
        this.x = x;
        this.y = y;
    }
    // Constructor sao chép: Khởi tạo điểm từ điểm khác
    public Point2D(Point2D p) {
        this.x = p.x;
        this.y = p.y;
    }
	public void Input() {
        Console.Write("Nhập hoành độ x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Nhập tung độ y: ");
        y = int.Parse(Console.ReadLine());
    }
    public override string ToString() => $"({x}, {y})";
	public void Move(int newX, int newY) {
		x = newX;
		y = newY;
	}
	public bool IsOrigin() => x == 0 && y == 0;
	public double Distance(Point2D p){
        return Math.Sqrt(Math.Pow(p.x - this.x, 2) + Math.Pow(p.y - this.y, 2));
    }
    // Hàm tĩnh: Tính khoảng cách giữa 2 điểm p1 và p2
    public static double Distance(Point2D p1, Point2D p2) {
        return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
    }
}
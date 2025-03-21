class DayPhanSo {
	PhanSo[]  arr;
	public int slptu;
	public DayPhanSo() {
		arr = new PhanSo[0];
	}
	public DayPhanSo(int sl) {
		arr = new PhanSo[sl];
		this.slptu = sl;
	}
	public PhanSo this[int i] {
		get	{ return arr[i];	}
		set	{ arr[i] = value;	}
	}
	public void InitArr() {
		Console.WriteLine("Vui lòng nhập dãy phân số: ");
		for (int i = 0; i < this.slptu; i++) {
			PhanSo mauSo = this[i];
			Console.Write("Vui lòng nhập tử số của phân số thứ" + i + ":");
			int newTu = Convert.ToInt32(Console.ReadLine());
			Console.Write("Vui lòng nhập mẫu số của phân số thứ" + i + ":");
			int newMau = Convert.ToInt32(Console.ReadLine());
			this[i] = new PhanSo(newTu, newMau);
		}
	}
	public void Print() {
		Console.WriteLine("Dãy phân sốlà: ");
		for (int i = 0; i < this.slptu; i++) {
			this[i].Print();
			if(i != this.slptu - 1)
				Console.Write(", ");
		}
		Console.WriteLine();
	}
	public PhanSo AddArr() {
		if (this.slptu == 0)
			return new PhanSo(); // Trả về 0/1 nếu dãy rỗng

		PhanSo kq = this[0]; // Lấy phân số đầu tiên làm tổng ban đầu
		for (int i = 1; i < this.slptu; i++) {
			kq = kq + this[i]; // Cộng từng phần tử vào tổng
		}
		return kq.Reduce(); // Rút gọn kết quả cuối cùng
	}

}
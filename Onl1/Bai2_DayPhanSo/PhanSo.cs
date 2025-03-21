class PhanSo {
	int tuSo, mauSo;
	public PhanSo() {
		tuSo = 0;
		mauSo = 1;
	}
	public PhanSo(int soNguyen) {
		tuSo = soNguyen;
		mauSo = 1;
	}
	public PhanSo(int tuSoArg, int mauSoArg) {
		tuSo = tuSoArg;
		mauSo = mauSoArg;
	}
	  // Hàm tìm ước chung lớn nhất (UCLN)
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    // Hàm rút gọn phân số
    public PhanSo Reduce() {
        int gcd = GCD(tuSo, mauSo);
        return new PhanSo(tuSo / gcd, mauSo / gcd);
    }
	// a/b + c/d = a*d + c*b / b*d
	public static PhanSo operator + (PhanSo a, PhanSo b) {
		return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
	}
	// a/b - c/d = a*d - c*b / b*d
	public static PhanSo operator - (PhanSo a, PhanSo b) {
		return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
	}
	// a/b * c/d = a*c / b*d
	public static PhanSo operator * (PhanSo a, PhanSo b) {
		return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
	}
	// a/b / c/d = a*d / b*c
	public static PhanSo operator / (PhanSo a, PhanSo b) {
		return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
	}
	// So sánh lớn hơn a/b và c/d => a/b - c/d > 0
	public static bool operator > (PhanSo a, PhanSo b) {
		PhanSo kq = a - b;
		return kq.mauSo > 0;
	}
	// So sánh nhỏ hơn a/b và c/d => a/b - c/d < 0
	public static bool operator < (PhanSo a, PhanSo b) {
		PhanSo kq = a - b;
		return kq.mauSo < 0;
	}
	public void Print() {
    	Console.WriteLine(tuSo + "/" + mauSo);
	}
}
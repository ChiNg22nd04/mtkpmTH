class Television : ElectronicGoods {
	public Television(IPrice price) : base(price) {
		this.type = "Television";
		this.cost = 2000;
	}
}
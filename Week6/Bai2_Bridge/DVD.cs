class DVD : ElectronicGoods {
	public DVD(IPrice price) : base(price) {
		this.type = "DVD";
 		this.cost = 3000;
	}

	public void DoubleDiscount() {
		// Normal discount(10%)
		Discount(10);
		// Festive season additional discount
		Discount(5);
	}	
}
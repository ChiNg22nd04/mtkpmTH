abstract class ElectronicGoods {
	private IPrice price;
	public string type;
	public double cost;
	public ElectronicGoods(IPrice price) {
		this.price = price;
	}
	public void Details() {
		price.DisplayDetails(type, cost);
	}
	// additional method
	public void Discount(int percentage) {
		price.GetDiscount(percentage);
	}

}
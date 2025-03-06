class OnlinePrice : IPrice {

	public void DisplayDetails(string productType, double price) {
		Console.Write($"\n{productType} price at online is : {price}$");
	}
	public void GetDiscount(int percentage) {
		Console.Write($"\nAt online, you can get upto {percentage}% discount.");
	}

}
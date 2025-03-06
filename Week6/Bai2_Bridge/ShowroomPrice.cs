class ShowroomPrice : IPrice {
	public virtual void DisplayDetails(string productType, double price) {
		Console.Write($"\n{productType} price at showroom is : {price + 300}$");
	}
	public void GetDiscount(int percentage) {
		Console.Write($"\nAt showroom, additional {percentage}% discount can be approved.");
	}
}
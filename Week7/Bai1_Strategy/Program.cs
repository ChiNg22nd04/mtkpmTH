internal class Program
{
    private static void Main(string[] args)
    {
 		// Prepare strategies
		var normalStrategy = new NormalStrategy();
		var happyHourStrategy = new HappyHourStrategy();
		var firstCustomer = new CustomerBill(normalStrategy);
		// Normal billing
		firstCustomer.Add(1.0, 1);
		// Start Happy Hour
		firstCustomer.Strategy = happyHourStrategy;
		firstCustomer.Add(1.0, 2);
		// New Customer
		CustomerBill secondCustomer = new CustomerBill(happyHourStrategy);
		secondCustomer.Add(0.8, 1);
		// The Customer pays
		firstCustomer.Print();
		// End Happy Hour
		secondCustomer.Strategy = normalStrategy;
		secondCustomer.Add(1.3, 2);
		secondCustomer.Add(2.5, 1);
		secondCustomer.Print();
	}
}

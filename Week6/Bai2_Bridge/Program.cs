internal class Program
{
    private static void Main(string[] args)
    {
		Console.WriteLine("***Alternative Implementation of Bridge Pattern.* **");
		#region Television details
		Console.WriteLine("Verifying the market price of a television.");
		ElectronicGoods eItem = new Television(new OnlinePrice());
		// Verifying online price details
		eItem.Details();
		// Giving 10% discount
		eItem.Discount(10);
		// Verifying showroom price
		eItem = new Television(new ShowroomPrice());
		eItem.Details();
		// Giving 10% discount
		eItem.Discount(10);
		#endregion
		#region DVD details
		Console.WriteLine("\n\nNow checking the DVD details.");
		eItem = new DVD(new OnlinePrice());
		eItem.Details();
		// Giving 10% discount
		eItem.Discount(10);
		// Verifying showroom price
		eItem = new DVD(new ShowroomPrice());
		eItem.Details();
		Console.WriteLine("\nIn showroom, you want to give double discounts at festive season.");
		Console.WriteLine("For DVD, you can get double discounts using the DoubleDiscount() method.");
		//eItem.Discount();
		Console.WriteLine("For example, in festive season:");
		((DVD)eItem).DoubleDiscount();
 		#endregion

	}
}
abstract class BanknoteHandler  : IBanknoteHandler  {
	protected IBanknoteHandler nextHandler;
	protected int denomination;  
	public BanknoteHandler(int denomination) => this.denomination = denomination;
	public void SetNextHandler(IBanknoteHandler next) => this.nextHandler = next;
	public void Handle(int amount) {
		if (amount >= denomination) {
			int numNotes = amount / denomination;
			int remainder = amount % denomination;
			Console.WriteLine($"Dùng {numNotes} tờ {denomination} VND");
			if (remainder > 0 && nextHandler != null)
				nextHandler.Handle(remainder);
		}
		else if (nextHandler != null)
			nextHandler.Handle(amount);
	}
}

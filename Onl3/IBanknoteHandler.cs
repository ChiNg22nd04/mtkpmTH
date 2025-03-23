interface IBanknoteHandler {
	void SetNextHandler(IBanknoteHandler next);
	void Handle(int amount);
}
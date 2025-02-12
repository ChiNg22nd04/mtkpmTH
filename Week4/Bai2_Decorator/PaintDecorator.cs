class PaintDecorator : AbstractDecorator {
	public PaintDecorator(AbstractHome _home) : base(_home) {
		this.AdditionalPrice = 2500;
	}

	public override void MakeHome() {
		base.MakeHome();
		PaintHome();
	}

	private void PaintHome() {
		Console.WriteLine($"--Painting done.Pay additional ${AdditionalPrice} for it .");
	}

}
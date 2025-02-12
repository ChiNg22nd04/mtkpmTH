class FloorDecorator : AbstractDecorator {
	public FloorDecorator(AbstractHome _home) : base(_home) {
		this.AdditionalPrice = 2500;
	}

	public override void MakeHome() {
		base.MakeHome();
		AddFloor();
	}

	private void AddFloor() {
		Console.WriteLine($"-Additional Floor added.Pay additional ${AdditionalPrice} for it .");
	}

}
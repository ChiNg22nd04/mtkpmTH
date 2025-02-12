abstract class AbstractDecorator : AbstractHome {
	protected AbstractHome home;
	public AbstractDecorator(AbstractHome _home) {
		this.home = _home;
		this.AdditionalPrice = 0;
	}

	public override void MakeHome() {
		home.MakeHome();
	}
}
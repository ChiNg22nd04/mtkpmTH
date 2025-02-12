class Proxy : Subject {
	private ConcreteSubject _realSubject;
	public override void DoSomeWork() {
		Console.WriteLine("Proxy call happening now...");
		if (_realSubject == null) {
			_realSubject = new ConcreteSubject();
			Console.WriteLine("Proxy: Instantiating ConcreteSubject...");
		} 
		_realSubject.DoSomeWork();
	}
	
}

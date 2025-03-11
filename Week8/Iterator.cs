class Iterator : IAbstractIterator {
	Collection collection;
	int current = 0;
	int step = 1;
	// Constructor
	public Iterator(Collection collection) {
		this.collection = collection;
	}
	public Item First() {
		current = 0;
		return collection[current] as Item;
	}
	public Item Next() {
		current += step;
		if (!IsDone)
			return collection[current] as Item;
		else
			return null;
	}
	public int Step {
		get { return step; }
		set { step = value; }
	}
	public Item CurrentItem {
		get { return collection[current] as Item; }
	}
	public bool IsDone {
		get { return current >= collection.Count; }
	}
}
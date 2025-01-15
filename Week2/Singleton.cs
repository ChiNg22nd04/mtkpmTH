sealed class Singleton {
	private static readonly Singleton instance = new Singleton();
    private int myInt; // Bộ đếm số lần gọi GetInstance
    private int totalInstances = 0;

    private Singleton() {
        Console.WriteLine("Instantiating inside the private constructor.");
        totalInstances++;
        Console.WriteLine("Number of instances = {0}", totalInstances);
    }

    public static Singleton GetInstance {
        get {
            instance.myInt++; // Tăng bộ đếm mỗi lần gọi
            Console.WriteLine("GetInstance called {0} times.", instance.myInt);
            return instance;
        }
    }
}
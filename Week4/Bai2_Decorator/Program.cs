internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Decorator Pattern Demo ***\n");
		#region Scenario-1
        // Scenario 1: Xây nhà, thêm tầng, sau đó sơn
        Console.WriteLine("\n** Scenario-1: Building home, adding floor, and then painting it **");
        AbstractHome home = new ConcreteHome();
        Console.WriteLine("Current bill breakdown:");
        home.MakeHome();

        home = new FloorDecorator(home);
        Console.WriteLine("\nFloor added. Current bill breakdown:");
        home.MakeHome();

        home = new PaintDecorator(home);
        Console.WriteLine("\nPaint applied. Current bill breakdown:");
        home.MakeHome();
		#endregion
        // Scenario 2: Xây nhà, sơn trước, sau đó thêm hai tầng
		#region Scenario-2
        Console.WriteLine("\n** Scenario-2: Building home, painting it, and then adding two additional floors **");
        home = new ConcreteHome();
        Console.WriteLine("\nReverting to original home. Current bill breakdown:");
        home.MakeHome();

        home = new PaintDecorator(home);
        Console.WriteLine("\nPaint applied. Current bill breakdown:");
        home.MakeHome();

        home = new FloorDecorator(home);
        Console.WriteLine("\nFloor added. Current bill breakdown:");
        home.MakeHome();

        home = new FloorDecorator(home);
        Console.WriteLine("\nAnother floor added. Current bill breakdown:");
        home.MakeHome();
		#endregion

	}
}
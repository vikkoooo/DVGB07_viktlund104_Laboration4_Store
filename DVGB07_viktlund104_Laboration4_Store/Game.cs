namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Game : IMedia
	{
		// Media implementations
		public int Quantity { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		
		// Game specific implementations
		public string Platform { get; set; }
		
		// Constructor for new game
		public Game()
		{
			// Get unique ID
			Id = FileHandler.IdGenerator;
			FileHandler.IdGenerator++;
		}

		// This constructor will be used when loading from file and want to assign ID ourselves
		public Game(int id)
		{
			Id = id;
		}
		
		public override string ToString()
		{
			return $"Quantity: {Quantity}, Id: {Id}, Name: {Name}, Price: {Price}, Platform: {Platform}";
		}
	}
}
namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Game
	{
		// Media implementations
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		
		// Game specific implementations
		public string Platform { get; set; }
		
		public Game()
		{
			// Get unique ID
			Id = FileHandler.IdGenerator;
			FileHandler.IdGenerator++;
		}

		public Game(int id)
		{
			Id = id;
		}
	}
}
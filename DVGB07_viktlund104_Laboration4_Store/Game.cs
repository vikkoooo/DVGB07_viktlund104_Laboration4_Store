namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Game : IMedia
	{
		// Media implementations
		public int Id { get; set; }
		public int Quantity { get; set; }
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
		
		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}, Price: {Price}, Platform: {Platform}";
		}
	}
}
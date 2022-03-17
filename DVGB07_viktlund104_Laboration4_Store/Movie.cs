namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Movie
	{
		// Media implementations
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		
		// Movie specific implementations
		public string Format { get; set; }
		public int PlayingTime { get; set; }
		
		public Movie()
		{
			// Get unique ID
			Id = FileHandler.IdGenerator;
			FileHandler.IdGenerator++;
		}
		
		public Movie(int id)
		{
			Id = id;
		}
	}
}
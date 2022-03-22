namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Movie : IMedia
	{
		// Media implementations
		public int Quantity { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		
		// Movie specific implementations
		public string Format { get; set; }
		public int PlayingTime { get; set; }
		
		// Constructor for a new movie
		public Movie()
		{
			// Get unique ID
			Id = FileHandler.IdGenerator;
			FileHandler.IdGenerator++;
		}
		
		// This constructor will be used when loading from file and want to assign ID ourselves
		public Movie(int id)
		{
			Id = id;
		}

		public override string ToString()
		{
			return $"Quantity: {Quantity}, Id: {Id}, Name: {Name}, Price: {Price}, Format: {Format}, PlayingTime: {PlayingTime}";
		}
	}
}
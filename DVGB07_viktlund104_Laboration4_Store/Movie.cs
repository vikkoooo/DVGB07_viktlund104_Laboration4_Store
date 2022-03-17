namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Movie : IMedia
	{
		// Media implementations
		public int Id { get; set; }
		public int Quantity { get; set; }
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
		
		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}, Price: {Price}, Format: {Format}, Playing time: {PlayingTime}";
		}
	}
}
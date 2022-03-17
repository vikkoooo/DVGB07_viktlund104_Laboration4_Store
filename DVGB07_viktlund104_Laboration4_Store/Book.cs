using System.Net;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public class Book : IMedia
	{
		// Media implementations
		public int Id { get; set; }
		public int Quantity { get; set; }

		public string Name { get; set; }
		public double Price { get; set; }
		
		// Book specific implementations
		public string Author { get; set; }
		public string Genre { get; set; }
		public string Format { get; set; }
		public string Language { get; set; }

		public Book()
		{
			// Get unique ID
			Id = FileHandler.IdGenerator;
			FileHandler.IdGenerator++;
		}
		
		public Book(int id)
		{
			Id = id;
		}

		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}, Price: {Price}, Author: {Author}, Genre: {Genre}, Format: {Format}, Language: {Language}";
		}
	}
}
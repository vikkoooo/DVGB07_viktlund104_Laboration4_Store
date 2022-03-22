namespace DVGB07_viktlund104_Laboration4_Store
{
	public interface IMedia
	{
		// All Media items in the store will have these properties
		int Quantity { get; set; }
		int Id { get; }
		string Name { get; set; }
		double Price { get; set; }
	}
}
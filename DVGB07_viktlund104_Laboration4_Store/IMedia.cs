namespace DVGB07_viktlund104_Laboration4_Store
{
	public interface IMedia
	{
		int Quantity { get; set; }
		int Id { get; }
		string Name { get; set; }
		double Price { get; set; }

	}
}
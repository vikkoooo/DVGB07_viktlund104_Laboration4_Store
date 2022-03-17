namespace DVGB07_viktlund104_Laboration4_Store
{
	public interface IMedia
	{
		int Id { get; }
		int Quantity { get; set; }
		string Name { get; set; }
		double Price { get; set; }

	}
}
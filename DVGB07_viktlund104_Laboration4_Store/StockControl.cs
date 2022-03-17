using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class StockControl : UserControl
	{
		private BindingSource bookSource, gameSource, movieSource;

		public StockControl(FileHandler db)
		{
			InitializeComponent();
			
			// Initialize our bindingsources to gridviews
			bookSource = new BindingSource();
			bookSource.DataSource = db.BookList;
			bookDataGridView.DataSource = bookSource;

			gameSource = new BindingSource();
			gameSource.DataSource = db.GameList;
			gameDataGridView.DataSource = gameSource;
			
			movieSource = new BindingSource();
			movieSource.DataSource = db.MovieList;
			movieDataGridView.DataSource = movieSource;
		}
	}
}
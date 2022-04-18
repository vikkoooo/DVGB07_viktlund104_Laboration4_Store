using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class StockControl : UserControl
	{
		private BindingSource bookSource, gameSource, movieSource;
		private Book selectedBook;
		private Game selectedGame;
		private Movie selectedMovie;
		private Dictionary<int, int> shipmentList; // Key is ID, value is quantity
		private MainForm mainForm; // reference to mainform

		// Constructor initializes our components and data
		public StockControl(FileHandler db, MainForm mainForm)
		{
			InitializeComponent();
			shipmentList = new Dictionary<int, int>();
			this.mainForm = mainForm;

			// Initialize our BindingSources to GridViews
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

		// Helper method that updates the listbox display. It is used after a product is added to the shipment list
		private void UpdateShippingUI()
		{
			shipmentListBox.Items.Clear();

			foreach (var e in shipmentList)
			{
				shipmentListBox.Items.Add($"ID: {e.Key}, Quantity: {e.Value}");
			}
		}

		// Helper method that checks if a specific item ID is present in any of the lists with items.
		// In other words, if it exists in our system. If it does, method will return true. Otherwise false 
		private bool ItemIsPresentInList(int idToCheck)
		{
			foreach (Book book in bookSource)
			{
				if (book.Id == idToCheck)
				{
					return true;
				}
			}

			foreach (Game game in gameSource)
			{
				if (game.Id == idToCheck)
				{
					return true;
				}
			}

			foreach (Movie movie in movieSource)
			{
				if (movie.Id == idToCheck)
				{
					return true;
				}
			}

			return false;
		}

		/*
		 * EVENTS
		 */
		// Which book is currently selected in the ui?
		private void bookDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (bookDataGridView.SelectedRows.Count < 1)
			{
				return;
			}

			selectedBook = (Book) bookDataGridView.SelectedRows[0].DataBoundItem;
		}

		// Which game is currently selected in the ui?
		private void gameDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (gameDataGridView.SelectedRows.Count < 1)
			{
				return;
			}

			selectedGame = (Game) gameDataGridView.SelectedRows[0].DataBoundItem;
		}

		// Which movie is currently selected in the ui?
		private void movieDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (movieDataGridView.SelectedRows.Count < 1)
			{
				return;
			}

			selectedMovie = (Movie) movieDataGridView.SelectedRows[0].DataBoundItem;
		}

		/*
		 * Book buttons
		 */
		private void newBookButton_Click(object sender, EventArgs e)
		{
			var newBookForm = new NewBookForm();
			newBookForm.StartPosition = FormStartPosition.CenterParent;

			var dialogResult = newBookForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				bookSource.Add(newBookForm.Book);
				mainForm.ForceUpdateSales();
			}
		}

		private void editBookButton_Click(object sender, EventArgs e)
		{
			var editBookForm = new EditBookForm(selectedBook);
			editBookForm.StartPosition = FormStartPosition.CenterParent;
			editBookForm.ShowDialog();

			bookSource.ResetCurrentItem(); // Update UI
			mainForm.ForceUpdateSales();
		}

		private void deleteBookButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show($"Are your sure?\nCurrent stock: {selectedBook.Quantity}", "Remove Book",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				bookSource.Remove(selectedBook);
				mainForm.ForceUpdateSales();
			}
		}

		/*
		 * Game buttons
		 */
		private void newGameButton_Click(object sender, EventArgs e)
		{
			var newGameForm = new NewGameForm();
			newGameForm.StartPosition = FormStartPosition.CenterParent;

			var dialogResult = newGameForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				gameSource.Add(newGameForm.Game);
				mainForm.ForceUpdateSales();
			}
		}

		private void editGameButton_Click(object sender, EventArgs e)
		{
			var editGameForm = new EditGameForm(selectedGame);
			editGameForm.StartPosition = FormStartPosition.CenterParent;
			editGameForm.ShowDialog();

			gameSource.ResetCurrentItem();
			mainForm.ForceUpdateSales();
		}

		private void deleteGameButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show($"Are your sure?\nCurrent stock: {selectedGame.Quantity}", "Remove Game",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				gameSource.Remove(selectedGame);
				mainForm.ForceUpdateSales();
			}
		}

		/*
		 * Movie buttons
		 */
		private void newMovieButton_Click(object sender, EventArgs e)
		{
			var newMovieForm = new NewMovieForm();
			newMovieForm.StartPosition = FormStartPosition.CenterParent;

			var dialogResult = newMovieForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				movieSource.Add(newMovieForm.Movie);
				mainForm.ForceUpdateSales();
			}
		}

		private void editMovieButton_Click(object sender, EventArgs e)
		{
			var editMovieForm = new EditMovieForm(selectedMovie);
			editMovieForm.StartPosition = FormStartPosition.CenterParent;
			editMovieForm.ShowDialog();

			movieSource.ResetCurrentItem();
			mainForm.ForceUpdateSales();
		}

		private void deleteMovieButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show($"Are your sure?\nCurrent stock: {selectedMovie.Quantity}", "Remove Movie",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				movieSource.Remove(selectedMovie);
				mainForm.ForceUpdateSales();
			}
		}

		/*
		 * Shipment buttons
		 */
		private void addProductShipmentButton_Click(object sender, EventArgs e)
		{
			int itemId, quantity;

			// Validate inputs
			try
			{
				itemId = int.Parse(itemIdShipmentTextBox.Text);
				quantity = int.Parse(quantityShipmentTextBox.Text);
			}
			catch
			{
				MessageBox.Show("Values must be whole numbers only, not letters or decimals", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check that input is present in list, in other words, an ID that exists in the system.
			// It should not be possible to add shipments for items IDs that does not exist.
			if (!ItemIsPresentInList(itemId))
			{
				MessageBox.Show("Item ID must be something that exists", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// Quantity can not be negative or 0
			if (quantity <= 0)
			{
				MessageBox.Show("Quantity can not be 0 or negative.", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// All ok, try add to shipment
			try
			{
				shipmentList.Add(itemId, quantity);
			}
			// If this exception is caught, the item was previously added to the list. So we update the quantity
			catch (ArgumentException)
			{
				shipmentList[itemId] += quantity;
			}

			itemIdShipmentTextBox.Text = "";
			quantityShipmentTextBox.Text = "";

			UpdateShippingUI();
		}

		private void cancelProductShipmentButton_Click(object sender, EventArgs e)
		{
			itemIdShipmentTextBox.Text = "";
			quantityShipmentTextBox.Text = "";
		}

		// This method will loop through all the shipments entered, and add to the quantity of that item when found
		// Key is ID, Value is Quantity
		private void finalizeShipmentButton_Click(object sender, EventArgs e)
		{
			foreach (var shipment in shipmentList)
			{
				// Check books
				foreach (Book book in bookSource)
				{
					if (shipment.Key == book.Id)
					{
						book.Quantity += shipment.Value;
					}
				}

				// Games
				foreach (Game game in gameSource)
				{
					if (shipment.Key == game.Id)
					{
						game.Quantity += shipment.Value;
					}
				}

				// Movies
				foreach (Movie movie in movieSource)
				{
					if (shipment.Key == movie.Id)
					{
						movie.Quantity += shipment.Value;
					}
				}
			}

			// Update UI
			bookDataGridView.Refresh();
			gameDataGridView.Refresh();
			movieDataGridView.Refresh();
			mainForm.ForceUpdateSales();

			// Clear shipment data
			shipmentListBox.Items.Clear();
			shipmentList.Clear();
		}

		private void clearShipmentButton_Click(object sender, EventArgs e)
		{
			shipmentListBox.Items.Clear();
			shipmentList.Clear();
		}
	}
}
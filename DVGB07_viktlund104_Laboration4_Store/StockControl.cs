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
		private Dictionary<int, int> shipmentList;

		public StockControl(FileHandler db)
		{
			InitializeComponent();
			shipmentList = new Dictionary<int, int>();
			
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
		
		private void bookDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (bookDataGridView.SelectedRows.Count < 1)
			{
				return;
			}
			
			// Get the item in the view that we have selected
			selectedBook = (Book)bookDataGridView.SelectedRows[0].DataBoundItem;
		}

		private void gameDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (gameDataGridView.SelectedRows.Count < 1)
			{
				return;
			}
			
			// Get the item in the view that we have selected
			selectedGame = (Game)gameDataGridView.SelectedRows[0].DataBoundItem;
		}

		private void movieDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (movieDataGridView.SelectedRows.Count < 1)
			{
				return;
			}
			
			// Get the item in the view that we have selected
			selectedMovie = (Movie)movieDataGridView.SelectedRows[0].DataBoundItem;
		}

		private void newBookButton_Click(object sender, EventArgs e)
		{
			var newBookForm = new NewBookForm();
			newBookForm.StartPosition = FormStartPosition.CenterParent;
			
			var dialogResult = newBookForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				bookSource.Add(newBookForm.Book);
			}
		}
		
		private void editBookButton_Click(object sender, EventArgs e)
		{
			var editBookForm = new EditBookForm(selectedBook);
			editBookForm.StartPosition = FormStartPosition.CenterParent;
			editBookForm.ShowDialog();
			
			bookSource.ResetCurrentItem(); //update ui
		}

		private void deleteBookButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are your sure?", "Remove Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				bookSource.Remove(selectedBook);
			}
		}
		
		private void newGameButton_Click(object sender, EventArgs e)
		{
			var newGameForm = new NewGameForm();
			newGameForm.StartPosition = FormStartPosition.CenterParent;
			
			var dialogResult = newGameForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				gameSource.Add(newGameForm.Game);
			}
		}

		private void editGameButton_Click(object sender, EventArgs e)
		{
			var editGameForm = new EditGameForm(selectedGame);
			editGameForm.StartPosition = FormStartPosition.CenterParent;
			editGameForm.ShowDialog();
			
			gameSource.ResetCurrentItem();
		}

		private void deleteGameButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are your sure?", "Remove Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				gameSource.Remove(selectedGame);
			}		
		}
		
		private void newMovieButton_Click(object sender, EventArgs e)
		{
			var newMovieForm = new NewMovieForm();
			newMovieForm.StartPosition = FormStartPosition.CenterParent;
			
			var dialogResult = newMovieForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				movieSource.Add(newMovieForm.Movie);
			}
			
		}

		private void editMovieButton_Click(object sender, EventArgs e)
		{
			var editMovieForm = new EditMovieForm(selectedMovie);
			editMovieForm.StartPosition = FormStartPosition.CenterParent;
			editMovieForm.ShowDialog();
			
			movieSource.ResetCurrentItem();		
		}

		private void deleteMovieButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are your sure?", "Remove Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				movieSource.Remove(selectedMovie);
			}
		}

		private void addProductShipmentButton_Click(object sender, EventArgs e)
		{
			shipmentList.Add(int.Parse(itemIdShipmentTextBox.Text), int.Parse(quantityShipmentTextBox.Text));
			
			itemIdShipmentTextBox.Text = "";
			quantityShipmentTextBox.Text = "";

			UpdateListBox();
		}

		private void UpdateListBox()
		{
			shipmentListBox.Items.Clear();

			foreach (var e in shipmentList)
			{
				shipmentListBox.Items.Add($"ID: {e.Key}, Quantity: {e.Value}");
			}
		}

		private void cancelProductShipmentButton_Click(object sender, EventArgs e)
		{
			itemIdShipmentTextBox.Text = "";
			quantityShipmentTextBox.Text = "";
		}

		private void finalizeShipmentButton_Click(object sender, EventArgs e)
		{
			foreach (var pair in shipmentList)
			{
				// Check books
				foreach (Book book in bookSource)
				{
					if (pair.Key == book.Id)
					{
						book.Quantity += pair.Value;
					}
				}
				
				// Games
				foreach (Game game in gameSource)
				{
					if (pair.Key == game.Id)
					{
						game.Quantity += pair.Value;
					}
				}
				
				// Movies
				foreach (Movie movie in movieSource)
				{
					if (pair.Key == movie.Id)
					{
						movie.Quantity += pair.Value;
					}
				}
			}
			
			// Update UI
			bookDataGridView.Refresh();
			gameDataGridView.Refresh();
			movieDataGridView.Refresh();
			
			// Clear shipment data
			shipmentListBox.Items.Clear();
			shipmentList.Clear();
		}
	}
	
}
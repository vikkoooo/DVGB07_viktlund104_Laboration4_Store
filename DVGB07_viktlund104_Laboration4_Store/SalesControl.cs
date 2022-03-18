using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class SalesControl : UserControl
	{
		
		private BindingSource bookSource, gameSource, movieSource;
		private BindingSource bookTempSource, gameTempSource, movieTempSource;
		private Dictionary<int, int> shoppingCartList;
		private double totalPrice;

		public SalesControl(FileHandler db)
		{
			InitializeComponent();
			shoppingCartList = new Dictionary<int, int>();
			totalPrice = 0;
			
			// Initialize our bindingsources to gridviews
			bookSource = new BindingSource();
			bookSource.DataSource = db.BookList; // keep original source in bookSource

			// But we want to display only sources with quantity
			bookTempSource = AddBooksWithQuantity(bookSource);
			bookDataGridView.DataSource = bookTempSource;
			
			// Same as above but for game
			gameSource = new BindingSource();
			gameSource.DataSource = db.GameList;
			gameTempSource = AddGamesWithQuantity(gameSource);
			gameDataGridView.DataSource = gameTempSource;
			
			// movie
			movieSource = new BindingSource();
			movieSource.DataSource = db.MovieList;
			movieTempSource = AddMoviesWithQuantity(movieSource);
			movieDataGridView.DataSource = movieTempSource;

		}

		private BindingSource AddBooksWithQuantity(BindingSource source)
		{
			BindingSource newSource = new BindingSource();

			foreach (Book book in source)
			{
				if (book.Quantity > 0)
				{
					newSource.Add(book);
				}
			}

			return newSource;
		}
		
		private BindingSource AddGamesWithQuantity(BindingSource source)
		{
			BindingSource newSource = new BindingSource();

			foreach (Game game in source)
			{
				if (game.Quantity > 0)
				{
					newSource.Add(game);
				}
			}

			return newSource;
		}
		
		private BindingSource AddMoviesWithQuantity(BindingSource source)
		{
			BindingSource newSource = new BindingSource();

			foreach (Movie movie in source)
			{
				if (movie.Quantity > 0)
				{
					newSource.Add(movie);
				}
			}

			return newSource;
		}

		private void addProductShoppingCartButton_Click(object sender, EventArgs e)
		{
			shoppingCartList.Add(int.Parse(itemIdShoppingCartTextBox.Text), int.Parse(quantityShoppingCartTextBox.Text));

			itemIdShoppingCartTextBox.Text = "";
			quantityShoppingCartTextBox.Text = "";

			UpdateUI();
		}
		
		private void UpdateUI()
		{
			shoppingCartListBox.Items.Clear();
			totalPrice = 0;
			
			foreach (var e in shoppingCartList)
			{
				double price = FetchItemPrice(e.Key) * e.Value;
				totalPrice += price;
				shoppingCartListBox.Items.Add($"ID: {e.Key}, Quantity: {e.Value}, Price: {price}");
			}

			currentPriceLabel.Text = totalPrice.ToString();
		}

		private double FetchItemPrice(int itemId)
		{
			foreach (Book book in bookSource)
			{
				if (itemId == book.Id)
				{
					return book.Price;
				}
			}
				
			// Games
			foreach (Game game in gameSource)
			{
				if (itemId == game.Id)
				{
					return game.Price;
				}
			}
				
			// Movies
			foreach (Movie movie in movieSource)
			{
				if (itemId == movie.Id)
				{
					return movie.Price;
				}
			}

			return 0;
		}
		
		

		private void cancelProductShoppingCartButton_Click(object sender, EventArgs e)
		{
			itemIdShoppingCartTextBox.Text = "";
			quantityShoppingCartTextBox.Text = "";
		}

		private void finalizePurchaseButton_Click(object sender, EventArgs e)
		{
			foreach (var pair in shoppingCartList)
			{
				// Decrease quantity amount
				foreach (Book book in bookSource)
				{
					if (pair.Key == book.Id)
					{
						book.Quantity -= pair.Value;
					}
				}
				
				// Games
				foreach (Game game in gameSource)
				{
					if (pair.Key == game.Id)
					{
						game.Quantity -= pair.Value;
					}
				}
				
				// Movies
				foreach (Movie movie in movieSource)
				{
					if (pair.Key == movie.Id)
					{
						movie.Quantity -= pair.Value;
					}
				}
			}
			
			// Update UI
			bookDataGridView.Refresh();
			gameDataGridView.Refresh();
			movieDataGridView.Refresh();
			
			// Clear shopping cart data
			shoppingCartListBox.Items.Clear();
			shoppingCartList.Clear();
			totalPrice = 0;
			currentPriceLabel.Text = "";
		}

		private void emptyShoppingCartButton_Click(object sender, EventArgs e)
		{
			shoppingCartListBox.Items.Clear();
			shoppingCartList.Clear();
			totalPrice = 0;
			currentPriceLabel.Text = "";
		}
	}
}
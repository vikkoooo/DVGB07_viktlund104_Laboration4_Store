using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class SalesControl : UserControl
	{
		private BindingSource bookSource, gameSource, movieSource;
		private BindingSource bookTempSource, gameTempSource, movieTempSource;
		private Dictionary<int, int> shoppingCartList; // Key is ID, value is quantity
		private double totalPrice;

		// Constructor initializes our components and data
		public SalesControl(FileHandler db)
		{
			InitializeComponent();
			shoppingCartList = new Dictionary<int, int>();
			totalPrice = 0;

			// Initialize our BindingSources to GridViews
			bookSource = new BindingSource();
			bookSource.DataSource = db.BookList; // Keep original source in bookSource

			// But we want to display only sources with quantity
			bookTempSource = AddBooksWithQuantity(bookSource);
			bookDataGridView.DataSource = bookTempSource;

			// Same as above but for Game and Movie
			gameSource = new BindingSource();
			gameSource.DataSource = db.GameList;
			gameTempSource = AddGamesWithQuantity(gameSource);
			gameDataGridView.DataSource = gameTempSource;

			movieSource = new BindingSource();
			movieSource.DataSource = db.MovieList;
			movieTempSource = AddMoviesWithQuantity(movieSource);
			movieDataGridView.DataSource = movieTempSource;
		}

		// Helper methods that gives us a BindingSource of items only with quantity, since it is no point of us
		// displaying items that does not have quantity. We can not sell products without quantity anyway.
		// They are used in constructor.
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

		// Private helper method that updates the listbox which contains the current shopping cart, and current price
		private void UpdateShoppingCartUI()
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

		// Gets the price of an specific item ID
		private double FetchItemPrice(int idToCheck)
		{
			foreach (Book book in bookSource)
			{
				if (idToCheck == book.Id)
				{
					return book.Price;
				}
			}

			foreach (Game game in gameSource)
			{
				if (idToCheck == game.Id)
				{
					return game.Price;
				}
			}

			foreach (Movie movie in movieSource)
			{
				if (idToCheck == movie.Id)
				{
					return movie.Price;
				}
			}

			return 0; // Return 0 if we didn't find any price
		}

		// Helper method that checks if a specific item ID is present in any of the lists with items.
		// In other words, if it exists in our system. If it does, method will return true. Otherwise false 
		private bool ItemIsPresentInList(int idToCheck)
		{
			foreach (Book book in bookTempSource)
			{
				if (book.Id == idToCheck)
				{
					return true;
				}
			}

			foreach (Game game in gameTempSource)
			{
				if (game.Id == idToCheck)
				{
					return true;
				}
			}

			foreach (Movie movie in movieTempSource)
			{
				if (movie.Id == idToCheck)
				{
					return true;
				}
			}

			return false;
		}

		// Helper method that tells us if the quantity provided is above what is in stock for that specific item
		// Returns true if the quantity we are checking is indeed higher than the current stock, otherwise false 
		private bool QuantityAboveStock(int idToCheck, int quantityToCheck)
		{
			foreach (Book book in bookTempSource)
			{
				if (book.Id == idToCheck)
				{
					if (quantityToCheck > book.Quantity)
					{
						return true;
					}
				}
			}

			foreach (Game game in gameTempSource)
			{
				if (game.Id == idToCheck)
				{
					if (quantityToCheck > game.Quantity)
					{
						return true;
					}
				}
			}

			foreach (Movie movie in movieTempSource)
			{
				if (movie.Id == idToCheck)
				{
					if (quantityToCheck > movie.Quantity)
					{
						return true;
					}
				}
			}

			return false;
		}

		/*
		 * EVENTS
		 */
		private void addProductShoppingCartButton_Click(object sender, EventArgs e)
		{
			int itemId, quantity;

			// Validate inputs
			try
			{
				itemId = int.Parse(itemIdShoppingCartTextBox.Text);
				quantity = int.Parse(quantityShoppingCartTextBox.Text);
			}
			catch
			{
				MessageBox.Show("Values must be whole numbers only, not letters or decimals", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check that input is present in list of items with quantity. Should not be possible to sell items without
			// quantity or simply does not exist.
			if (!ItemIsPresentInList(itemId))
			{
				MessageBox.Show("Item ID must be something that exists or has current stock", "Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// Make sure quantity is not more than current stock
			if (QuantityAboveStock(itemId, quantity))
			{
				MessageBox.Show("Quantity can not be above stock.", "Error", MessageBoxButtons.OK,
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

			// All ok, try add to cart
			try
			{
				shoppingCartList.Add(itemId, quantity);
			}
			// If this exception is caught, the item was previously added to the list. So we update the quantity
			// as long as we don't update to a value larger than current stock
			catch (ArgumentException)
			{
				int oldQuantity = shoppingCartList[itemId];

				if (QuantityAboveStock(itemId, oldQuantity + quantity))
				{
					MessageBox.Show("Quantity can not be above stock.", "Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				// All good, update quantity
				shoppingCartList[itemId] += quantity;
			}

			itemIdShoppingCartTextBox.Text = "";
			quantityShoppingCartTextBox.Text = "";

			UpdateShoppingCartUI();
		}

		private void cancelProductShoppingCartButton_Click(object sender, EventArgs e)
		{
			itemIdShoppingCartTextBox.Text = "";
			quantityShoppingCartTextBox.Text = "";
		}

		// This method will loop through all the products entered, and remove quantity of that item when found
		// Key is ID, Value is Quantity
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
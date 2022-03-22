using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	// This class allows hard edit of the selected Book.
	public partial class EditBookForm : Form
	{
		private Book book;

		// Initializes the form and sets the field with the loaded data
		public EditBookForm(Book book_)
		{
			InitializeComponent();
			book = book_;
			
			quantityTextBox.Text = book.Quantity.ToString();
			idTextBox.Text = book.Id.ToString();
			nameTextBox.Text = book.Name;
			priceTextBox.Text = book.Price.ToString();
			authorTextBox.Text = book.Author;
			genreTextBox.Text = book.Genre;
			languageTextBox.Text = book.Language;
		}

		/*
		 * EVENTS
		 */
		private void okButton_Click(object sender, EventArgs e)
		{
			try
			{
				book.Quantity = int.Parse(quantityTextBox.Text);
				book.Id = int.Parse(idTextBox.Text);
				book.Name = nameTextBox.Text;
				book.Price = double.Parse(priceTextBox.Text);
				book.Author = authorTextBox.Text;
				book.Genre = genreTextBox.Text;
				book.Language = languageTextBox.Text;
			}
			// If this is caught, the user entered invalid data into some of the fields that will parse
			catch (Exception exception)
			{
				MessageBox.Show(
					$"An error was found. Please contact system administrator for help.\nMessage: {exception.Message}",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
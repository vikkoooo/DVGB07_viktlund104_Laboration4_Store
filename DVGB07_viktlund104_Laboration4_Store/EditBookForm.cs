using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class EditBookForm : Form
	{
		private Book book;
		
		public EditBookForm(Book book_)
		{
			InitializeComponent();
			book = book_;
			
			// Set fields
			quantityTextBox.Text = book.Quantity.ToString();
			idTextBox.Text = book.Id.ToString();
			nameTextBox.Text = book.Name;
			priceTextBox.Text = book.Price.ToString();
			authorTextBox.Text = book.Author;
			genreTextBox.Text = book.Genre;
			languageTextBox.Text = book.Language;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			book.Quantity = int.Parse(quantityTextBox.Text);
			book.Id = int.Parse(idTextBox.Text);
			book.Name = nameTextBox.Text;
			book.Price = double.Parse(priceTextBox.Text);
			book.Author = authorTextBox.Text;
			book.Genre = genreTextBox.Text;
			book.Language = languageTextBox.Text;

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
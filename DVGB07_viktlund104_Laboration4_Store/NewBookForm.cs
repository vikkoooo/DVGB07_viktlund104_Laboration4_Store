using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class NewBookForm : Form
	{
		public Book Book { get; set; }
		
		public NewBookForm()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Book = new Book();
			Book.Name = nameTextBox.Text;
			Book.Price = double.Parse(priceTextBox.Text);
			Book.Author = authorTextBox.Text;
			Book.Genre = genreTextBox.Text;
			Book.Format = formatTextBox.Text;
			Book.Language = languageTextBox.Text;

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
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
			// Early exit if forced fields are empty
			if (ForcedFieldsEmpty())
			{
				return;
			}
			
			Book = new Book();
			Book.Name = nameTextBox.Text;
			try
			{
				Book.Price = double.Parse(priceTextBox.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Please enter price decimals with , and not .", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (Book.Price <= 0)
			{
				MessageBox.Show("Price cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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

		private bool ForcedFieldsEmpty()
		{
			if (String.IsNullOrWhiteSpace(nameTextBox.Text))
			{
				MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			if (String.IsNullOrWhiteSpace(priceTextBox.Text))
			{
				MessageBox.Show("Price can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			return false;
		}


	}
}
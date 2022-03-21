using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class NewMovieForm : Form
	{
		public Movie Movie { get; set; }
		
		
		public NewMovieForm()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (ForcedFieldsEmpty())
			{
				return;
			}
			
			Movie = new Movie();
			Movie.Name = nameTextBox.Text;

			try
			{
				Movie.Price = double.Parse(priceTextBox.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Please enter price decimals with , and not .", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (Movie.Price <= 0)
			{
				MessageBox.Show("Price cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			Movie.Format = formatTextBox.Text;

			if (!string.IsNullOrWhiteSpace(playingTimeTextBox.Text))
			{
				try
				{
					Movie.PlayingTime = int.Parse(playingTimeTextBox.Text);
				}
				catch (Exception exception)
				{
					MessageBox.Show("Playing time can not contain letters and must have no decimals", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				if (Movie.PlayingTime <= 0)
				{
					MessageBox.Show("Playing time cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			
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
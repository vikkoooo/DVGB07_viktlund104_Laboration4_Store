using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class NewMovieForm : Form
	{
		public Movie Movie { get; private set; }

		public NewMovieForm()
		{
			InitializeComponent();
		}

		// Helper method that will check if forced fields are left blank
		private bool ForcedFieldsEmpty()
		{
			if (string.IsNullOrWhiteSpace(nameTextBox.Text))
			{
				MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			if (string.IsNullOrWhiteSpace(priceTextBox.Text))
			{
				MessageBox.Show("Price can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			return false;
		}

		/*
		 * EVENTS
		 */
		private void okButton_Click(object sender, EventArgs e)
		{
			// Early exit
			if (ForcedFieldsEmpty())
			{
				return;
			}

			Movie = new Movie();
			Movie.Name = nameTextBox.Text;

			// Make sure price is entered correct
			try
			{
				Movie.Price = double.Parse(priceTextBox.Text);
			}
			catch
			{
				MessageBox.Show("Please enter price decimals with , and not .", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// Make sure price is not 0 or below
			if (Movie.Price <= 0)
			{
				MessageBox.Show("Price cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Movie.Format = formatTextBox.Text;

			// It is OK to leave the playing time empty, but if it's not left empty, we have to do some input validation
			if (!string.IsNullOrWhiteSpace(playingTimeTextBox.Text))
			{
				// Same logic as before when checking price
				try
				{
					Movie.PlayingTime = int.Parse(playingTimeTextBox.Text);
				}
				catch
				{
					MessageBox.Show("Playing time can not contain letters and must have no decimals", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// If previous check passed, same logic check as before, PlayingTime can not be 0 or negative
				if (Movie.PlayingTime <= 0)
				{
					MessageBox.Show("Playing time cannot be 0 or negative", "Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
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
	}
}
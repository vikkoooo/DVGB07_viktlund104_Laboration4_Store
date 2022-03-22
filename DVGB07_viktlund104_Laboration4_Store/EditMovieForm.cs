using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class EditMovieForm : Form
	{
		private Movie movie;

		// Initializes the form and sets the field with the loaded data
		public EditMovieForm(Movie movie_)
		{
			InitializeComponent();
			movie = movie_;
			
			quantityTextBox.Text = movie.Quantity.ToString();
			idTextBox.Text = movie.Id.ToString();
			nameTextBox.Text = movie.Name;
			priceTextBox.Text = movie.Price.ToString();
			formatTextBox.Text = movie.Format;
			playingTimeTextBox.Text = movie.PlayingTime.ToString();
		}

		/*
		 * EVENTS
		 */
		private void okButton_Click(object sender, EventArgs e)
		{
			try
			{
				movie.Quantity = int.Parse(quantityTextBox.Text);
				movie.Id = int.Parse(idTextBox.Text);
				movie.Name = nameTextBox.Text;
				movie.Price = double.Parse(priceTextBox.Text);
				movie.Format = formatTextBox.Text;
				movie.PlayingTime = int.Parse(playingTimeTextBox.Text);
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
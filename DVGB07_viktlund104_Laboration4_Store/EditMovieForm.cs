using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class EditMovieForm : Form
	{
		private Movie movie;
		
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

		private void okButton_Click(object sender, EventArgs e)
		{
			movie.Quantity = int.Parse(quantityTextBox.Text);
			movie.Id = int.Parse(idTextBox.Text);
			movie.Name = nameTextBox.Text;
			movie.Price = double.Parse(priceTextBox.Text);
			movie.Format = formatTextBox.Text;
			movie.PlayingTime = int.Parse(playingTimeTextBox.Text);

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
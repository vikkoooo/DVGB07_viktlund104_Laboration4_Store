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
			Movie = new Movie();
			Movie.Name = nameTextBox.Text;
			Movie.Price = double.Parse(priceTextBox.Text);
			Movie.Format = formatTextBox.Text;
			Movie.PlayingTime = int.Parse(playingTimeTextBox.Text);

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
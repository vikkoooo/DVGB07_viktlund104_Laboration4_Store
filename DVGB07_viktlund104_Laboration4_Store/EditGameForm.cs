using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class EditGameForm : Form
	{
		private Game game;
		
		public EditGameForm(Game game_)
		{
			InitializeComponent();
			game = game_;
			
			quantityTextBox.Text = game.Quantity.ToString();
			idTextBox.Text = game.Id.ToString();
			nameTextBox.Text = game.Name;
			priceTextBox.Text = game.Price.ToString();
			platformTextBox.Text = game.Platform;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			game.Quantity = int.Parse(quantityTextBox.Text);
			game.Id = int.Parse(idTextBox.Text);
			game.Name = nameTextBox.Text;
			game.Price = double.Parse(priceTextBox.Text);
			game.Platform = platformTextBox.Text;

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
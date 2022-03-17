using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class NewGameForm : Form
	{
		public Game Game { get; set; }
		
		public NewGameForm()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Game = new Game();
			Game.Name = nameTextBox.Text;
			Game.Price = double.Parse(priceTextBox.Text);
			Game.Platform = platformTextBox.Text;

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
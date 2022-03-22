using System;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class NewGameForm : Form
	{
		public Game Game { get; private set; }

		public NewGameForm()
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

			Game = new Game();
			Game.Name = nameTextBox.Text;

			// Make sure price is entered correct
			try
			{
				Game.Price = double.Parse(priceTextBox.Text);
			}
			catch
			{
				MessageBox.Show("Please enter price decimals with , and not .", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// Make sure price is not 0 or below
			if (Game.Price <= 0)
			{
				MessageBox.Show("Price cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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
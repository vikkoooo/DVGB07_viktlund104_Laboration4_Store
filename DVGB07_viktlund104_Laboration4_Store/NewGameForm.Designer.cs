using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class NewGameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.platformTextBox = new System.Windows.Forms.TextBox();
			this.platformLabel = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(238, 84);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(157, 84);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// platformTextBox
			// 
			this.platformTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.platformTextBox.Location = new System.Drawing.Point(90, 58);
			this.platformTextBox.Name = "platformTextBox";
			this.platformTextBox.Size = new System.Drawing.Size(223, 20);
			this.platformTextBox.TabIndex = 3;
			// 
			// platformLabel
			// 
			this.platformLabel.Location = new System.Drawing.Point(8, 61);
			this.platformLabel.Name = "platformLabel";
			this.platformLabel.Size = new System.Drawing.Size(100, 15);
			this.platformLabel.TabIndex = 11;
			this.platformLabel.Text = "Platform";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.priceTextBox.Location = new System.Drawing.Point(90, 32);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 2;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(8, 35);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 14;
			this.priceLabel.Text = "Price* (SEK)";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Location = new System.Drawing.Point(90, 6);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 1;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(8, 9);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 13;
			this.nameLabel.Text = "Name*";
			// 
			// NewGameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 124);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.platformTextBox);
			this.Controls.Add(this.platformLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.MinimumSize = new System.Drawing.Size(341, 163);
			this.Name = "NewGameForm";
			this.Text = "New Game";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox platformTextBox;
		private System.Windows.Forms.Label platformLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;

		#endregion
	}
}
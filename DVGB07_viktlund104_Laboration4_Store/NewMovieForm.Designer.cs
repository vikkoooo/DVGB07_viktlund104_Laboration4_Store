using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class NewMovieForm
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
			this.playingTimeTextBox = new System.Windows.Forms.TextBox();
			this.playingTimeLabel = new System.Windows.Forms.Label();
			this.formatTextBox = new System.Windows.Forms.TextBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.formatLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(242, 116);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 21;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(161, 116);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 22;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// playingTimeTextBox
			// 
			this.playingTimeTextBox.Location = new System.Drawing.Point(94, 90);
			this.playingTimeTextBox.Name = "playingTimeTextBox";
			this.playingTimeTextBox.Size = new System.Drawing.Size(223, 20);
			this.playingTimeTextBox.TabIndex = 18;
			// 
			// playingTimeLabel
			// 
			this.playingTimeLabel.Location = new System.Drawing.Point(12, 93);
			this.playingTimeLabel.Name = "playingTimeLabel";
			this.playingTimeLabel.Size = new System.Drawing.Size(100, 15);
			this.playingTimeLabel.TabIndex = 9;
			this.playingTimeLabel.Text = "Playing Time";
			// 
			// formatTextBox
			// 
			this.formatTextBox.Location = new System.Drawing.Point(94, 64);
			this.formatTextBox.Name = "formatTextBox";
			this.formatTextBox.Size = new System.Drawing.Size(223, 20);
			this.formatTextBox.TabIndex = 17;
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(94, 38);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 16;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(12, 41);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 14;
			this.priceLabel.Text = "Price (SEK)";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(94, 12);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 15;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(12, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 13;
			this.nameLabel.Text = "Name";
			// 
			// formatLabel
			// 
			this.formatLabel.Location = new System.Drawing.Point(12, 67);
			this.formatLabel.Name = "formatLabel";
			this.formatLabel.Size = new System.Drawing.Size(76, 15);
			this.formatLabel.TabIndex = 9;
			this.formatLabel.Text = "Format";
			// 
			// NewMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 155);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.playingTimeTextBox);
			this.Controls.Add(this.formatLabel);
			this.Controls.Add(this.playingTimeLabel);
			this.Controls.Add(this.formatTextBox);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "NewMovieForm";
			this.Text = "New Movie";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label formatLabel;

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox formatTextBox;
		private System.Windows.Forms.TextBox playingTimeTextBox;
		private System.Windows.Forms.Label playingTimeLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;

		#endregion
	}
}
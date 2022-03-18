using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class EditMovieForm
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
			this.formatLabel = new System.Windows.Forms.Label();
			this.quantityTextBox = new System.Windows.Forms.TextBox();
			this.quantityLabel = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.priceLabel = new System.Windows.Forms.Label();
			this.idLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(241, 168);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 23;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(160, 168);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 25;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// playingTimeTextBox
			// 
			this.playingTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.playingTimeTextBox.Location = new System.Drawing.Point(93, 142);
			this.playingTimeTextBox.Name = "playingTimeTextBox";
			this.playingTimeTextBox.Size = new System.Drawing.Size(223, 20);
			this.playingTimeTextBox.TabIndex = 20;
			// 
			// playingTimeLabel
			// 
			this.playingTimeLabel.Location = new System.Drawing.Point(11, 145);
			this.playingTimeLabel.Name = "playingTimeLabel";
			this.playingTimeLabel.Size = new System.Drawing.Size(100, 15);
			this.playingTimeLabel.TabIndex = 24;
			this.playingTimeLabel.Text = "Playing Time";
			// 
			// formatTextBox
			// 
			this.formatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.formatTextBox.Location = new System.Drawing.Point(93, 116);
			this.formatTextBox.Name = "formatTextBox";
			this.formatTextBox.Size = new System.Drawing.Size(223, 20);
			this.formatTextBox.TabIndex = 19;
			// 
			// formatLabel
			// 
			this.formatLabel.Location = new System.Drawing.Point(11, 119);
			this.formatLabel.Name = "formatLabel";
			this.formatLabel.Size = new System.Drawing.Size(100, 15);
			this.formatLabel.TabIndex = 27;
			this.formatLabel.Text = "Format";
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityTextBox.Location = new System.Drawing.Point(93, 12);
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.Size = new System.Drawing.Size(223, 20);
			this.quantityTextBox.TabIndex = 15;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Location = new System.Drawing.Point(11, 15);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(100, 15);
			this.quantityLabel.TabIndex = 32;
			this.quantityLabel.Text = "Quantity";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.priceTextBox.Location = new System.Drawing.Point(93, 90);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 18;
			// 
			// idTextBox
			// 
			this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.idTextBox.Location = new System.Drawing.Point(93, 38);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(223, 20);
			this.idTextBox.TabIndex = 16;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(11, 93);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 31;
			this.priceLabel.Text = "Price (SEK)";
			// 
			// idLabel
			// 
			this.idLabel.Location = new System.Drawing.Point(11, 41);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(100, 15);
			this.idLabel.TabIndex = 30;
			this.idLabel.Text = "ID";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Location = new System.Drawing.Point(93, 64);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 17;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(11, 67);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 29;
			this.nameLabel.Text = "Name";
			// 
			// EditMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 207);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.playingTimeTextBox);
			this.Controls.Add(this.playingTimeLabel);
			this.Controls.Add(this.formatTextBox);
			this.Controls.Add(this.formatLabel);
			this.Controls.Add(this.quantityTextBox);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.MinimumSize = new System.Drawing.Size(347, 246);
			this.Name = "EditMovieForm";
			this.Text = "Edit Movie";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox formatTextBox;
		private System.Windows.Forms.Label formatLabel;
		private System.Windows.Forms.TextBox playingTimeTextBox;
		private System.Windows.Forms.Label playingTimeLabel;
		private System.Windows.Forms.TextBox quantityTextBox;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;

		#endregion
	}
}
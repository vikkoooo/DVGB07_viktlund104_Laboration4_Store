using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class EditGameForm
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
			this.cancelButton.Location = new System.Drawing.Point(244, 142);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(163, 142);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// platformTextBox
			// 
			this.platformTextBox.Location = new System.Drawing.Point(96, 116);
			this.platformTextBox.Name = "platformTextBox";
			this.platformTextBox.Size = new System.Drawing.Size(223, 20);
			this.platformTextBox.TabIndex = 5;
			// 
			// platformLabel
			// 
			this.platformLabel.Location = new System.Drawing.Point(14, 119);
			this.platformLabel.Name = "platformLabel";
			this.platformLabel.Size = new System.Drawing.Size(100, 15);
			this.platformLabel.TabIndex = 27;
			this.platformLabel.Text = "Platform";
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.Location = new System.Drawing.Point(96, 12);
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.Size = new System.Drawing.Size(223, 20);
			this.quantityTextBox.TabIndex = 1;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Location = new System.Drawing.Point(14, 15);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(100, 15);
			this.quantityLabel.TabIndex = 32;
			this.quantityLabel.Text = "Quantity";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(96, 90);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(223, 20);
			this.priceTextBox.TabIndex = 4;
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(96, 38);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(223, 20);
			this.idTextBox.TabIndex = 2;
			// 
			// priceLabel
			// 
			this.priceLabel.Location = new System.Drawing.Point(14, 93);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(100, 15);
			this.priceLabel.TabIndex = 31;
			this.priceLabel.Text = "Price (SEK)";
			// 
			// idLabel
			// 
			this.idLabel.Location = new System.Drawing.Point(14, 41);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(100, 15);
			this.idLabel.TabIndex = 30;
			this.idLabel.Text = "ID";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(96, 64);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(223, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(14, 67);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 15);
			this.nameLabel.TabIndex = 29;
			this.nameLabel.Text = "Name";
			// 
			// EditGameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 189);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.platformTextBox);
			this.Controls.Add(this.platformLabel);
			this.Controls.Add(this.quantityTextBox);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "EditGameForm";
			this.Text = "Edit Game";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox platformTextBox;
		private System.Windows.Forms.Label platformLabel;
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
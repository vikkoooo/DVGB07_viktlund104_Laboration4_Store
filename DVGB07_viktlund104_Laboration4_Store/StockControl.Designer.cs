using System.ComponentModel;

namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class StockControl
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bookDataGridView = new System.Windows.Forms.DataGridView();
			this.gameDataGridView = new System.Windows.Forms.DataGridView();
			this.movieDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// bookDataGridView
			// 
			this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookDataGridView.Location = new System.Drawing.Point(0, 0);
			this.bookDataGridView.Name = "bookDataGridView";
			this.bookDataGridView.Size = new System.Drawing.Size(767, 150);
			this.bookDataGridView.TabIndex = 0;
			// 
			// gameDataGridView
			// 
			this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gameDataGridView.Location = new System.Drawing.Point(0, 190);
			this.gameDataGridView.Name = "gameDataGridView";
			this.gameDataGridView.Size = new System.Drawing.Size(767, 150);
			this.gameDataGridView.TabIndex = 0;
			// 
			// movieDataGridView
			// 
			this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.movieDataGridView.Location = new System.Drawing.Point(0, 378);
			this.movieDataGridView.Name = "movieDataGridView";
			this.movieDataGridView.Size = new System.Drawing.Size(767, 150);
			this.movieDataGridView.TabIndex = 0;
			// 
			// StockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.movieDataGridView);
			this.Controls.Add(this.gameDataGridView);
			this.Controls.Add(this.bookDataGridView);
			this.Name = "StockControl";
			this.Size = new System.Drawing.Size(946, 586);
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.gameDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.movieDataGridView)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridView gameDataGridView;
		private System.Windows.Forms.DataGridView movieDataGridView;

		private System.Windows.Forms.DataGridView bookDataGridView;

		#endregion
	}
}
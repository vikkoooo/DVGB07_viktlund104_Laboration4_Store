namespace DVGB07_viktlund104_Laboration4_Store
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.stockTab = new System.Windows.Forms.TabPage();
			this.salesTab = new System.Windows.Forms.TabPage();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.stockTab);
			this.mainTabControl.Controls.Add(this.salesTab);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1069, 680);
			this.mainTabControl.TabIndex = 0;
			// 
			// stockTab
			// 
			this.stockTab.Location = new System.Drawing.Point(4, 22);
			this.stockTab.Name = "stockTab";
			this.stockTab.Padding = new System.Windows.Forms.Padding(3);
			this.stockTab.Size = new System.Drawing.Size(1061, 654);
			this.stockTab.TabIndex = 0;
			this.stockTab.Text = "Stock";
			this.stockTab.UseVisualStyleBackColor = true;
			// 
			// salesTab
			// 
			this.salesTab.Location = new System.Drawing.Point(4, 22);
			this.salesTab.Name = "salesTab";
			this.salesTab.Padding = new System.Windows.Forms.Padding(3);
			this.salesTab.Size = new System.Drawing.Size(1012, 654);
			this.salesTab.TabIndex = 1;
			this.salesTab.Text = "Sales";
			this.salesTab.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 680);
			this.Controls.Add(this.mainTabControl);
			this.Name = "MainForm";
			this.Text = "Store";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage stockTab;
		private System.Windows.Forms.TabPage salesTab;

		#endregion
	}
}
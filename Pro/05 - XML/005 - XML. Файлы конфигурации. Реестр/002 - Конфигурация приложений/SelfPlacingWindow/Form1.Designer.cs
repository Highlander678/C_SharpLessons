namespace SelfPlacingWindow
{
	partial class Form1
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
			SaveSettings();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1018, 304);
            this.listBox1.TabIndex = 0;
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(0, 320);
            this.buttonChooseColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(156, 35);
            this.buttonChooseColor.TabIndex = 1;
            this.buttonChooseColor.Text = "Choose Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 403);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Self Placing Window";
            this.ResumeLayout(false);

		}

		#endregion
	}
}


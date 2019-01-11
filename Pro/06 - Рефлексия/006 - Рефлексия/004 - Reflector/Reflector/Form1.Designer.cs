namespace WindowsApplication1
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ôàéëToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.îòêğûòüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çàêğûòüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ôàéëToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ôàéëToolStripMenuItem
            // 
            this.ôàéëToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.îòêğûòüToolStripMenuItem,
            this.çàêğûòüToolStripMenuItem});
            this.ôàéëToolStripMenuItem.Name = "ôàéëToolStripMenuItem";
            this.ôàéëToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ôàéëToolStripMenuItem.Text = "File";
            // 
            // îòêğûòüToolStripMenuItem
            // 
            this.îòêğûòüToolStripMenuItem.Name = "îòêğûòüToolStripMenuItem";
            this.îòêğûòüToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.îòêğûòüToolStripMenuItem.Text = "Open";
            this.îòêğûòüToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // çàêğûòüToolStripMenuItem
            // 
            this.çàêğûòüToolStripMenuItem.Name = "çàêğûòüToolStripMenuItem";
            this.çàêğûòüToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.çàêğûòüToolStripMenuItem.Text = "Close";
            this.çàêğûòüToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 41);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(736, 345);
            this.textBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 414);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "REFLECTOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ôàéëToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem îòêğûòüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çàêğûòüToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox;
    }
}


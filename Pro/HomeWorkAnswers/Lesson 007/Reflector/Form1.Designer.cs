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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAtrType = new System.Windows.Forms.CheckBox();
            this.checkBoxAtrMember = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ôàéëToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
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
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(754, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 184);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Îòîáğàçèòü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetView_Click);
            // 
            // checkBoxAtrType
            // 
            this.checkBoxAtrType.AutoSize = true;
            this.checkBoxAtrType.Location = new System.Drawing.Point(26, 400);
            this.checkBoxAtrType.Name = "checkBoxAtrType";
            this.checkBoxAtrType.Size = new System.Drawing.Size(239, 17);
            this.checkBoxAtrType.TabIndex = 6;
            this.checkBoxAtrType.Text = "Âûâîäèòü èíôîğìàöèş îá àòğèáóòàõ òèïà";
            this.checkBoxAtrType.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtrMember
            // 
            this.checkBoxAtrMember.AutoSize = true;
            this.checkBoxAtrMember.Location = new System.Drawing.Point(313, 400);
            this.checkBoxAtrMember.Name = "checkBoxAtrMember";
            this.checkBoxAtrMember.Size = new System.Drawing.Size(245, 17);
            this.checkBoxAtrMember.TabIndex = 7;
            this.checkBoxAtrMember.Text = "Âûâîäèòü èíôîğìàöèş îá àòğèáóòàõ ÷ëåíà";
            this.checkBoxAtrMember.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 429);
            this.Controls.Add(this.checkBoxAtrMember);
            this.Controls.Add(this.checkBoxAtrType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAtrType;
        private System.Windows.Forms.CheckBox checkBoxAtrMember;
    }
}


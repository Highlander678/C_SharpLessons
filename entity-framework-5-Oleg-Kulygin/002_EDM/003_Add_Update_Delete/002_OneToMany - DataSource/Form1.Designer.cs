namespace _002_OneToMany
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtnUpdateModel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.modelsGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.carsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnDelCar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.modelsGroupBox.SuspendLayout();
            this.carsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.carAddButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DeleteModel";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.modelDeleteButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtnUpdateModel
            // 
            this.dtnUpdateModel.Location = new System.Drawing.Point(227, 77);
            this.dtnUpdateModel.Name = "dtnUpdateModel";
            this.dtnUpdateModel.Size = new System.Drawing.Size(96, 23);
            this.dtnUpdateModel.TabIndex = 9;
            this.dtnUpdateModel.Text = "UpdateModel";
            this.dtnUpdateModel.UseVisualStyleBackColor = true;
            this.dtnUpdateModel.Click += new System.EventHandler(this.modelUpdateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCars);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 161);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cars";
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(6, 19);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(246, 134);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // dgvModel
            // 
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(6, 19);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModel.Size = new System.Drawing.Size(360, 134);
            this.dgvModel.TabIndex = 6;
            this.dgvModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModel_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvModel);
            this.groupBox3.Location = new System.Drawing.Point(286, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 161);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(12, 51);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(43, 13);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(60, 48);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(12, 25);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(42, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Factory";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(60, 22);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(100, 20);
            this.txtFactory.TabIndex = 0;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(76, 74);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(100, 20);
            this.txtEngine.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 25);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Engine";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 51);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(31, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(76, 48);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // modelsGroupBox
            // 
            this.modelsGroupBox.Controls.Add(this.button1);
            this.modelsGroupBox.Controls.Add(this.dtnUpdateModel);
            this.modelsGroupBox.Controls.Add(this.txtEngine);
            this.modelsGroupBox.Controls.Add(this.btnDelete);
            this.modelsGroupBox.Controls.Add(this.lblGender);
            this.modelsGroupBox.Controls.Add(this.txtName);
            this.modelsGroupBox.Controls.Add(this.label2);
            this.modelsGroupBox.Controls.Add(this.lblPhone);
            this.modelsGroupBox.Controls.Add(this.txtColor);
            this.modelsGroupBox.Location = new System.Drawing.Point(286, 178);
            this.modelsGroupBox.Name = "modelsGroupBox";
            this.modelsGroupBox.Size = new System.Drawing.Size(372, 108);
            this.modelsGroupBox.TabIndex = 31;
            this.modelsGroupBox.TabStop = false;
            this.modelsGroupBox.Text = "Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modelAddButton_Click);
            // 
            // carsGroupBox
            // 
            this.carsGroupBox.Controls.Add(this.btnClear);
            this.carsGroupBox.Controls.Add(this.btnUpdateCar);
            this.carsGroupBox.Controls.Add(this.btnDelCar);
            this.carsGroupBox.Controls.Add(this.lblLName);
            this.carsGroupBox.Controls.Add(this.btnAdd);
            this.carsGroupBox.Controls.Add(this.txtCountry);
            this.carsGroupBox.Controls.Add(this.lblFName);
            this.carsGroupBox.Controls.Add(this.txtFactory);
            this.carsGroupBox.Location = new System.Drawing.Point(10, 178);
            this.carsGroupBox.Name = "carsGroupBox";
            this.carsGroupBox.Size = new System.Drawing.Size(258, 108);
            this.carsGroupBox.TabIndex = 28;
            this.carsGroupBox.TabStop = false;
            this.carsGroupBox.Text = "Cars";
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(172, 44);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCar.TabIndex = 7;
            this.btnUpdateCar.Text = "UpdateCar";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.carUpdateButton_Click);
            // 
            // btnDelCar
            // 
            this.btnDelCar.Location = new System.Drawing.Point(172, 73);
            this.btnDelCar.Name = "btnDelCar";
            this.btnDelCar.Size = new System.Drawing.Size(75, 23);
            this.btnDelCar.TabIndex = 6;
            this.btnDelCar.Text = "DeleteCar";
            this.btnDelCar.UseVisualStyleBackColor = true;
            this.btnDelCar.Click += new System.EventHandler(this.carDeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.modelsGroupBox);
            this.Controls.Add(this.carsGroupBox);
            this.Name = "Form1";
            this.Text = "OneToMany";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.modelsGroupBox.ResumeLayout(false);
            this.modelsGroupBox.PerformLayout();
            this.carsGroupBox.ResumeLayout(false);
            this.carsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button dtnUpdateModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox modelsGroupBox;
        private System.Windows.Forms.GroupBox carsGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelCar;
        private System.Windows.Forms.Button btnUpdateCar;
    }
}


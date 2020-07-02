namespace Autosalon
{
    partial class Availability1
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
            this.listViewAvailability1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxId_Firms = new System.Windows.Forms.ComboBox();
            this.labelId_Firms = new System.Windows.Forms.Label();
            this.comboBoxId_Auto = new System.Windows.Forms.ComboBox();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.labelId_Auto = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewAvailability1
            // 
            this.listViewAvailability1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAvailability1.FullRowSelect = true;
            this.listViewAvailability1.GridLines = true;
            this.listViewAvailability1.HideSelection = false;
            this.listViewAvailability1.Location = new System.Drawing.Point(176, 13);
            this.listViewAvailability1.MultiSelect = false;
            this.listViewAvailability1.Name = "listViewAvailability1";
            this.listViewAvailability1.Size = new System.Drawing.Size(613, 282);
            this.listViewAvailability1.TabIndex = 27;
            this.listViewAvailability1.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability1.View = System.Windows.Forms.View.Details;
            this.listViewAvailability1.SelectedIndexChanged += new System.EventHandler(this.listViewAvailability1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id ";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id Фирмы";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id Машины";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Наличие";
            this.columnHeader4.Width = 144;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(390, 335);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(508, 335);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(636, 335);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 42;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxId_Firms
            // 
            this.comboBoxId_Firms.FormattingEnabled = true;
            this.comboBoxId_Firms.Location = new System.Drawing.Point(12, 32);
            this.comboBoxId_Firms.Name = "comboBoxId_Firms";
            this.comboBoxId_Firms.Size = new System.Drawing.Size(153, 21);
            this.comboBoxId_Firms.TabIndex = 43;
            // 
            // labelId_Firms
            // 
            this.labelId_Firms.AutoSize = true;
            this.labelId_Firms.Location = new System.Drawing.Point(12, 16);
            this.labelId_Firms.Name = "labelId_Firms";
            this.labelId_Firms.Size = new System.Drawing.Size(44, 13);
            this.labelId_Firms.TabIndex = 44;
            this.labelId_Firms.Text = "Фирма";
            // 
            // comboBoxId_Auto
            // 
            this.comboBoxId_Auto.FormattingEnabled = true;
            this.comboBoxId_Auto.Location = new System.Drawing.Point(12, 83);
            this.comboBoxId_Auto.Name = "comboBoxId_Auto";
            this.comboBoxId_Auto.Size = new System.Drawing.Size(153, 21);
            this.comboBoxId_Auto.TabIndex = 45;
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Items.AddRange(new object[] {
            "В наличие",
            "Не в наличии"});
            this.comboBoxAvailability.Location = new System.Drawing.Point(12, 135);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(153, 21);
            this.comboBoxAvailability.TabIndex = 46;
            // 
            // labelId_Auto
            // 
            this.labelId_Auto.AutoSize = true;
            this.labelId_Auto.Location = new System.Drawing.Point(12, 67);
            this.labelId_Auto.Name = "labelId_Auto";
            this.labelId_Auto.Size = new System.Drawing.Size(48, 13);
            this.labelId_Auto.TabIndex = 47;
            this.labelId_Auto.Text = "Машина";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(9, 119);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(44, 13);
            this.labelAvailability.TabIndex = 48;
            this.labelAvailability.Text = "Наличе";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autosalon.Properties.Resources.unnamed__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-100, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Availability1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelId_Auto);
            this.Controls.Add(this.comboBoxAvailability);
            this.Controls.Add(this.comboBoxId_Auto);
            this.Controls.Add(this.labelId_Firms);
            this.Controls.Add(this.comboBoxId_Firms);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAvailability1);
            this.Name = "Availability1";
            this.Text = "Availability1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAvailability1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxId_Firms;
        private System.Windows.Forms.Label labelId_Firms;
        private System.Windows.Forms.ComboBox comboBoxId_Auto;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.Label labelId_Auto;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
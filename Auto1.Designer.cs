namespace Autosalon
{
    partial class Auto1
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
            this.listViewAuto1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxState_Number = new System.Windows.Forms.TextBox();
            this.textBoxYear_of_issue = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelState_Number = new System.Windows.Forms.Label();
            this.labelYear_of_issue = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewAuto1
            // 
            this.listViewAuto1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAuto1.FullRowSelect = true;
            this.listViewAuto1.GridLines = true;
            this.listViewAuto1.HideSelection = false;
            this.listViewAuto1.Location = new System.Drawing.Point(175, 12);
            this.listViewAuto1.MultiSelect = false;
            this.listViewAuto1.Name = "listViewAuto1";
            this.listViewAuto1.Size = new System.Drawing.Size(613, 282);
            this.listViewAuto1.TabIndex = 26;
            this.listViewAuto1.UseCompatibleStateImageBehavior = false;
            this.listViewAuto1.View = System.Windows.Forms.View.Details;
            this.listViewAuto1.SelectedIndexChanged += new System.EventHandler(this.listViewAuto1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Машины";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Модель";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цвет";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Гос номер";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Год выпуска";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            this.columnHeader6.Width = 93;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(409, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(656, 351);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 29;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 32);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(138, 20);
            this.textBoxModel.TabIndex = 30;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Белый",
            "Чёрный",
            "Синий",
            "Красный"});
            this.comboBoxColor.Location = new System.Drawing.Point(12, 78);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(138, 21);
            this.comboBoxColor.TabIndex = 31;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 16);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(91, 13);
            this.labelModel.TabIndex = 32;
            this.labelModel.Text = "Модель машины";
            // 
            // textBoxState_Number
            // 
            this.textBoxState_Number.Location = new System.Drawing.Point(12, 127);
            this.textBoxState_Number.Name = "textBoxState_Number";
            this.textBoxState_Number.Size = new System.Drawing.Size(138, 20);
            this.textBoxState_Number.TabIndex = 33;
            // 
            // textBoxYear_of_issue
            // 
            this.textBoxYear_of_issue.Location = new System.Drawing.Point(12, 167);
            this.textBoxYear_of_issue.Name = "textBoxYear_of_issue";
            this.textBoxYear_of_issue.Size = new System.Drawing.Size(138, 20);
            this.textBoxYear_of_issue.TabIndex = 34;
            this.textBoxYear_of_issue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxaAuto_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 205);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(138, 20);
            this.textBoxPrice.TabIndex = 35;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxaAuto_KeyPress);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 62);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(32, 13);
            this.labelColor.TabIndex = 36;
            this.labelColor.Text = "Цвет";
            // 
            // labelState_Number
            // 
            this.labelState_Number.AutoSize = true;
            this.labelState_Number.Location = new System.Drawing.Point(12, 111);
            this.labelState_Number.Name = "labelState_Number";
            this.labelState_Number.Size = new System.Drawing.Size(60, 13);
            this.labelState_Number.TabIndex = 37;
            this.labelState_Number.Text = "Гос номер";
            // 
            // labelYear_of_issue
            // 
            this.labelYear_of_issue.AutoSize = true;
            this.labelYear_of_issue.Location = new System.Drawing.Point(12, 151);
            this.labelYear_of_issue.Name = "labelYear_of_issue";
            this.labelYear_of_issue.Size = new System.Drawing.Size(71, 13);
            this.labelYear_of_issue.TabIndex = 38;
            this.labelYear_of_issue.Text = "Год выпуска";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 190);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 39;
            this.labelPrice.Text = "Цена";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(530, 351);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autosalon.Properties.Resources.unnamed__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-103, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Auto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear_of_issue);
            this.Controls.Add(this.labelState_Number);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxYear_of_issue);
            this.Controls.Add(this.textBoxState_Number);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAuto1);
            this.Name = "Auto1";
            this.Text = "Auto1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAuto1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxState_Number;
        private System.Windows.Forms.TextBox textBoxYear_of_issue;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelState_Number;
        private System.Windows.Forms.Label labelYear_of_issue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
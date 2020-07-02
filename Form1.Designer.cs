namespace Autosalon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonFirms = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(22, 67);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(181, 59);
            this.buttonAuto.TabIndex = 0;
            this.buttonAuto.Text = "Автомобили";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonFirms
            // 
            this.buttonFirms.Location = new System.Drawing.Point(22, 181);
            this.buttonFirms.Name = "buttonFirms";
            this.buttonFirms.Size = new System.Drawing.Size(186, 50);
            this.buttonFirms.TabIndex = 2;
            this.buttonFirms.Text = "Фирмы";
            this.buttonFirms.UseVisualStyleBackColor = true;
            this.buttonFirms.Click += new System.EventHandler(this.buttonFirms_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.Location = new System.Drawing.Point(22, 288);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(186, 49);
            this.buttonAvailability.TabIndex = 3;
            this.buttonAvailability.Text = "Наличие";
            this.buttonAvailability.UseVisualStyleBackColor = true;
            this.buttonAvailability.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autosalon.Properties.Resources.unnamed__4_;
            this.pictureBox1.Location = new System.Drawing.Point(298, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonFirms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFirms;
        private System.Windows.Forms.Button buttonAvailability;
    }
}


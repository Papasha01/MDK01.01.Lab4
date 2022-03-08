
namespace SpectralLines
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
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.ComboBoxElements = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox1
            // 
            this.picturebox1.Location = new System.Drawing.Point(16, 43);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(520, 54);
            this.picturebox1.TabIndex = 27;
            this.picturebox1.TabStop = false;
            this.picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picturebox1_Paint);
            // 
            // ComboBoxElements
            // 
            this.ComboBoxElements.Font = new System.Drawing.Font("Times New Roman", 10.25F);
            this.ComboBoxElements.FormattingEnabled = true;
            this.ComboBoxElements.Location = new System.Drawing.Point(96, 9);
            this.ComboBoxElements.Name = "ComboBoxElements";
            this.ComboBoxElements.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxElements.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Элемент";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonShow.Location = new System.Drawing.Point(223, 8);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(84, 29);
            this.buttonShow.TabIndex = 24;
            this.buttonShow.Text = "show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 109);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.ComboBoxElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.ComboBox ComboBoxElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
    }
}


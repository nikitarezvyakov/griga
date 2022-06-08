
namespace griga
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
            this.passlb = new System.Windows.Forms.Label();
            this.passbut1 = new System.Windows.Forms.Button();
            this.passlb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lengh = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passlb
            // 
            this.passlb.AutoSize = true;
            this.passlb.Location = new System.Drawing.Point(32, 133);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(0, 17);
            this.passlb.TabIndex = 1;
            this.passlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passbut1
            // 
            this.passbut1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passbut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbut1.Location = new System.Drawing.Point(547, 47);
            this.passbut1.Name = "passbut1";
            this.passbut1.Size = new System.Drawing.Size(265, 131);
            this.passbut1.TabIndex = 2;
            this.passbut1.Text = "Сгенерировать";
            this.passbut1.UseVisualStyleBackColor = false;
            this.passbut1.Click += new System.EventHandler(this.passbut1_Click);
            // 
            // passlb1
            // 
            this.passlb1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passlb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passlb1.Location = new System.Drawing.Point(142, 23);
            this.passlb1.Name = "passlb1";
            this.passlb1.Size = new System.Drawing.Size(345, 28);
            this.passlb1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(652, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Майк Вазовски";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(652, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Скопировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(652, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lengh
            // 
            this.lengh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengh.Location = new System.Drawing.Point(221, 99);
            this.lengh.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lengh.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lengh.Name = "lengh";
            this.lengh.Size = new System.Drawing.Size(132, 28);
            this.lengh.TabIndex = 8;
            this.lengh.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.CheckOnClick = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.FormattingEnabled = true;
            this.checkBox1.Items.AddRange(new object[] {
            "Цифры",
            "Буквы и специальные символы"});
            this.checkBox1.Location = new System.Drawing.Point(35, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(318, 73);
            this.checkBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длина пароля :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::griga.Properties.Resources._278936471_9702b9cf69e046b114de2ffc28722647_800;
            this.pictureBox2.Location = new System.Drawing.Point(114, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::griga.Properties.Resources.tip;
            this.pictureBox1.Location = new System.Drawing.Point(0, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(842, 503);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lengh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passlb1);
            this.Controls.Add(this.passbut1);
            this.Controls.Add(this.passlb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            ((System.ComponentModel.ISupportInitialize)(this.lengh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.Button passbut1;
        private System.Windows.Forms.Label passlb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown lengh;
        private System.Windows.Forms.CheckedListBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


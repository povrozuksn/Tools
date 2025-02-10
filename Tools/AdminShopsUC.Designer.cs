namespace Tools
{
    partial class AdminShopsUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddPicShopBtn = new System.Windows.Forms.Button();
            this.PicShopPB = new System.Windows.Forms.PictureBox();
            this.AddShopBtn = new System.Windows.Forms.Button();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NameShopTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShopPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 217);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель управления Магазинами";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RatingComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AddPicShopBtn);
            this.panel2.Controls.Add(this.PicShopPB);
            this.panel2.Controls.Add(this.AddShopBtn);
            this.panel2.Controls.Add(this.CityComboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.NameShopTB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 304);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование магазина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(50, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "- поля, обязательный для заполнения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(37, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(93, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(125, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingComboBox.Location = new System.Drawing.Point(41, 111);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(289, 33);
            this.RatingComboBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Рейтинг";
            // 
            // AddPicShopBtn
            // 
            this.AddPicShopBtn.Location = new System.Drawing.Point(373, 37);
            this.AddPicShopBtn.Name = "AddPicShopBtn";
            this.AddPicShopBtn.Size = new System.Drawing.Size(316, 29);
            this.AddPicShopBtn.TabIndex = 21;
            this.AddPicShopBtn.Text = "Добавить картинку";
            this.AddPicShopBtn.UseVisualStyleBackColor = true;
            this.AddPicShopBtn.Click += new System.EventHandler(this.AddPicShopBtn_Click);
            // 
            // PicShopPB
            // 
            this.PicShopPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicShopPB.Location = new System.Drawing.Point(373, 72);
            this.PicShopPB.Name = "PicShopPB";
            this.PicShopPB.Size = new System.Drawing.Size(316, 192);
            this.PicShopPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicShopPB.TabIndex = 20;
            this.PicShopPB.TabStop = false;
            // 
            // AddShopBtn
            // 
            this.AddShopBtn.Location = new System.Drawing.Point(39, 224);
            this.AddShopBtn.Name = "AddShopBtn";
            this.AddShopBtn.Size = new System.Drawing.Size(157, 40);
            this.AddShopBtn.TabIndex = 19;
            this.AddShopBtn.Text = "Добавить";
            this.AddShopBtn.UseVisualStyleBackColor = true;
            this.AddShopBtn.Click += new System.EventHandler(this.AddShopBtn_Click);
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(41, 167);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(289, 33);
            this.CityComboBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Город";
            // 
            // NameShopTB
            // 
            this.NameShopTB.Location = new System.Drawing.Point(39, 53);
            this.NameShopTB.Name = "NameShopTB";
            this.NameShopTB.Size = new System.Drawing.Size(291, 30);
            this.NameShopTB.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Название";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Добавление магазина";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminShopsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminShopsUC";
            this.Size = new System.Drawing.Size(955, 521);
            this.Load += new System.EventHandler(this.AdminShopsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShopPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddPicShopBtn;
        private System.Windows.Forms.PictureBox PicShopPB;
        private System.Windows.Forms.Button AddShopBtn;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameShopTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

namespace Tools
{
    partial class CategoryUC
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
            this.ShopPictureBox = new System.Windows.Forms.PictureBox();
            this.ShopNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopPictureBox
            // 
            this.ShopPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ShopPictureBox.Name = "ShopPictureBox";
            this.ShopPictureBox.Size = new System.Drawing.Size(314, 265);
            this.ShopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShopPictureBox.TabIndex = 2;
            this.ShopPictureBox.TabStop = false;
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopNameLabel.Location = new System.Drawing.Point(323, 3);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(98, 32);
            this.ShopNameLabel.TabIndex = 3;
            this.ShopNameLabel.Text = "label2";
            // 
            // CategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ShopNameLabel);
            this.Controls.Add(this.ShopPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryUC";
            this.Size = new System.Drawing.Size(925, 575);
            ((System.ComponentModel.ISupportInitialize)(this.ShopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ShopPictureBox;
        private System.Windows.Forms.Label ShopNameLabel;
    }
}

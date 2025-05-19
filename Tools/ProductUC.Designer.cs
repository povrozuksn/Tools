namespace Tools
{
    partial class ProductUC
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
            this.ProductPB = new System.Windows.Forms.PictureBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.OpisTB = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ValLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPB
            // 
            this.ProductPB.Location = new System.Drawing.Point(3, 3);
            this.ProductPB.Name = "ProductPB";
            this.ProductPB.Size = new System.Drawing.Size(303, 285);
            this.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPB.TabIndex = 0;
            this.ProductPB.TabStop = false;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(24, 313);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(64, 25);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "label1";
            // 
            // OpisTB
            // 
            this.OpisTB.Location = new System.Drawing.Point(312, 3);
            this.OpisTB.Multiline = true;
            this.OpisTB.Name = "OpisTB";
            this.OpisTB.Size = new System.Drawing.Size(429, 439);
            this.OpisTB.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(142, 372);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 25);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "label1";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(24, 429);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(64, 25);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "label1";
            // 
            // ValLabel
            // 
            this.ValLabel.AutoSize = true;
            this.ValLabel.Location = new System.Drawing.Point(24, 372);
            this.ValLabel.Name = "ValLabel";
            this.ValLabel.Size = new System.Drawing.Size(64, 25);
            this.ValLabel.TabIndex = 5;
            this.ValLabel.Text = "label1";
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.OpisTB);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ProductPB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(744, 495);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPB;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox OpisTB;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ValLabel;
    }
}

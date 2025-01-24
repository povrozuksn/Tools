namespace Tools
{
    partial class ToolsUC
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
            this.CategoryPB = new System.Windows.Forms.PictureBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryPB
            // 
            this.CategoryPB.Location = new System.Drawing.Point(3, 3);
            this.CategoryPB.Name = "CategoryPB";
            this.CategoryPB.Size = new System.Drawing.Size(262, 198);
            this.CategoryPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CategoryPB.TabIndex = 0;
            this.CategoryPB.TabStop = false;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(271, 16);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(64, 25);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "label1";
            // 
            // ToolsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryPB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToolsUC";
            this.Size = new System.Drawing.Size(657, 458);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CategoryPB;
        private System.Windows.Forms.Label CategoryLabel;
    }
}

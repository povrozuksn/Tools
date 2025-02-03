namespace Tools
{
    partial class AdminUC
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
            this.AdminShopsBtn = new System.Windows.Forms.Button();
            this.AdminCatBtn = new System.Windows.Forms.Button();
            this.AdminUsersBtn = new System.Windows.Forms.Button();
            this.AdminProdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminShopsBtn
            // 
            this.AdminShopsBtn.Location = new System.Drawing.Point(260, 103);
            this.AdminShopsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminShopsBtn.Name = "AdminShopsBtn";
            this.AdminShopsBtn.Size = new System.Drawing.Size(308, 47);
            this.AdminShopsBtn.TabIndex = 0;
            this.AdminShopsBtn.Text = "Управление магазинами";
            this.AdminShopsBtn.UseVisualStyleBackColor = true;
            this.AdminShopsBtn.Click += new System.EventHandler(this.AdminShopsBtn_Click);
            // 
            // AdminCatBtn
            // 
            this.AdminCatBtn.Location = new System.Drawing.Point(260, 176);
            this.AdminCatBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminCatBtn.Name = "AdminCatBtn";
            this.AdminCatBtn.Size = new System.Drawing.Size(308, 47);
            this.AdminCatBtn.TabIndex = 1;
            this.AdminCatBtn.Text = "Управление категориями";
            this.AdminCatBtn.UseVisualStyleBackColor = true;
            this.AdminCatBtn.Click += new System.EventHandler(this.AdminCatBtn_Click);
            // 
            // AdminUsersBtn
            // 
            this.AdminUsersBtn.Location = new System.Drawing.Point(260, 321);
            this.AdminUsersBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminUsersBtn.Name = "AdminUsersBtn";
            this.AdminUsersBtn.Size = new System.Drawing.Size(308, 47);
            this.AdminUsersBtn.TabIndex = 3;
            this.AdminUsersBtn.Text = "Управление пользователями";
            this.AdminUsersBtn.UseVisualStyleBackColor = true;
            this.AdminUsersBtn.Click += new System.EventHandler(this.AdminUsersBtn_Click);
            // 
            // AdminProdBtn
            // 
            this.AdminProdBtn.Location = new System.Drawing.Point(260, 248);
            this.AdminProdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminProdBtn.Name = "AdminProdBtn";
            this.AdminProdBtn.Size = new System.Drawing.Size(308, 47);
            this.AdminProdBtn.TabIndex = 2;
            this.AdminProdBtn.Text = "Управление товарами";
            this.AdminProdBtn.UseVisualStyleBackColor = true;
            this.AdminProdBtn.Click += new System.EventHandler(this.AdminProdBtn_Click);
            // 
            // AdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminUsersBtn);
            this.Controls.Add(this.AdminProdBtn);
            this.Controls.Add(this.AdminCatBtn);
            this.Controls.Add(this.AdminShopsBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminUC";
            this.Size = new System.Drawing.Size(846, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminShopsBtn;
        private System.Windows.Forms.Button AdminCatBtn;
        private System.Windows.Forms.Button AdminUsersBtn;
        private System.Windows.Forms.Button AdminProdBtn;
    }
}

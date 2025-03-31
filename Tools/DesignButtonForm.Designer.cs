namespace Tools
{
    partial class DesignButtonForm
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
            this.ExampleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonColorBTN = new System.Windows.Forms.Button();
            this.ButtonFontBTN = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ExampleButton
            // 
            this.ExampleButton.Location = new System.Drawing.Point(26, 49);
            this.ExampleButton.Name = "ExampleButton";
            this.ExampleButton.Size = new System.Drawing.Size(203, 47);
            this.ExampleButton.TabIndex = 11;
            this.ExampleButton.Text = "Текст";
            this.ExampleButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Образец";
            // 
            // ButtonColorBTN
            // 
            this.ButtonColorBTN.Location = new System.Drawing.Point(26, 219);
            this.ButtonColorBTN.Name = "ButtonColorBTN";
            this.ButtonColorBTN.Size = new System.Drawing.Size(549, 51);
            this.ButtonColorBTN.TabIndex = 9;
            this.ButtonColorBTN.Text = "Выберите цвет фона  кнопки";
            this.ButtonColorBTN.UseVisualStyleBackColor = true;
            this.ButtonColorBTN.Click += new System.EventHandler(this.ButtonColorBTN_Click);
            // 
            // ButtonFontBTN
            // 
            this.ButtonFontBTN.Location = new System.Drawing.Point(26, 155);
            this.ButtonFontBTN.Name = "ButtonFontBTN";
            this.ButtonFontBTN.Size = new System.Drawing.Size(549, 46);
            this.ButtonFontBTN.TabIndex = 8;
            this.ButtonFontBTN.Text = "Выберите шрифт, размер и цвет текста кнопки";
            this.ButtonFontBTN.UseVisualStyleBackColor = true;
            this.ButtonFontBTN.Click += new System.EventHandler(this.ButtonFontBTN_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // DesignButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 311);
            this.Controls.Add(this.ExampleButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonColorBTN);
            this.Controls.Add(this.ButtonFontBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DesignButtonForm";
            this.Text = "DesignButtonForm";
            this.Load += new System.EventHandler(this.DesignButtonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExampleButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonColorBTN;
        private System.Windows.Forms.Button ButtonFontBTN;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}